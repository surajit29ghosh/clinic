using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorAssist.Web.Models;
using DoctorAssist.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace DoctorAssist.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public HomeController(SignInManager<User> signInManager, UserManager<User> userManager, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            User user = _userManager.FindByNameAsync(model.UserName).Result;

            if (user != null)
            {
                if (user.Password.Equals(model.Password))
                {
                    var result = _signInManager.SignInAsync(user, false);
                    switch (user.UserRole)
                    {
                        case "Doctor":
                            return RedirectToAction("Home", "Doctor");
                        case "Patient":
                            return RedirectToAction("Home", "Patient");
                        default:
                            {
                                ViewBag.NotValidUser = "User identity is not set properly!";
                                return View();
                            }
                    }
                }
                else
                {
                    ViewBag.NotValidUser = string.Format("Invalid password for {0}!", model.UserName);
                    return View();
                }

            }
            else
            {
                ViewBag.NotValidUser = "User not present!";
                return View();
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
