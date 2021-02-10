using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using DoctorAssist.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Extensions.Internal;

namespace DoctorAssist.Blazor.Server.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        public string ReturnUrl { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            public string UserName { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        private InfraDBContext db;

        public LoginModel(InfraDBContext dBContext)
        {
            db = dBContext;
        }
        public async Task OnGetAsync()
        {
            //returnUrl = returnUrl ?? Url.Content("~/");
            // Clear the existing external cookie
            try
            {
                await HttpContext
                    .SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch { }
            //ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // *** !!! This is where you would validate the user !!! ***
            // In this example we just log the user in
            // (Always log the user in for this demo)

            Data.User result = ValidateUser();

            if (result == null)
                return Page();

            ProfileSettings profile = GetUserProfile(result.AssociationId);

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Input.UserName),
                    new Claim(ClaimTypes.Role, result.UserRole),
                    new Claim("sub", result.UserId.ToString()) 
                };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                RedirectUri = this.Request.Host.Value
            };
            try
            {
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
                return LocalRedirect(returnUrl);
            }
            catch
            {
                return Page();
            }
        }

        private User ValidateUser()
        {
            Data.User user = db.Users
                     .AsAsyncEnumerable()
                     .SingleOrDefault(p => p.UserName.Equals(Input.UserName, StringComparison.OrdinalIgnoreCase), CancellationToken.None).Result;


            if (user != null)
            {
                if (user.Password.Equals(Input.Password))
                {
                    switch (user.UserRole)
                    {
                        case "Doctor":
                            return user;
                        case "Patient":
                            return user;
                        default:
                            {
                                ViewData["Message"] = "User identity is not set properly!";
                                return null;
                            }
                    }
                }
                else
                {
                    ViewData["Message"] = string.Format("Invalid password for {0}!", Input.UserName);
                    return null;
                }

            }
            else
            {
                ViewData["Message"] = "User not present!";
                return null;
            }
        }

        private ProfileSettings GetUserProfile(Guid profileId)
        {
            ProfileSettings profile = db.DoctorSetting
                                      .AsAsyncEnumerable()
                                      .SingleOrDefault(d => d.DoctorId.Equals(profileId)).Result;

            return profile;
        }
    }
}