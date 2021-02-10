using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorAssist.Data;
using DoctorAssist.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAssist.Web.Controllers
{
    public class DoctorController : Controller
    {
        private readonly UserManager<User> _userManager;
        private InfraDBContext db;

        public DoctorController(UserManager<User> userManager, InfraDBContext context)
        {
            _userManager = userManager;
            db = context;
        }

        public IActionResult Home()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            User user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            if (user.UserRole.Equals("Patient"))
                return RedirectToAction("Home", "Patient");

            ProfileSettings doctor = db.DoctorSetting.Where(x => x.DoctorId.Equals(user.AssociationId)).FirstOrDefault();

            if (doctor == null)
                return RedirectToAction("Index", "Home");

            UserClientModel model = new UserClientModel
            {
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                UserRole = user.UserRole,
                UserId = user.UserId
            };

            var UserSettings = new
            {
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                UserRole =  user.UserId.Equals(user.AssociationId) ? user.UserRole : "Associate",
                AssociationId = user.AssociationId,
                UserId = user.UserId,
                Logo = doctor.LogoPath,
                Theme = doctor.Theme,
                ApiPath = "https://localhost:9001/"
            };

            ViewBag.User = UserSettings;

            return View();
            //return Redirect("/demo/");
        }

        public IActionResult Start()
        {
            return Redirect("/doctor/");
        }
    }
}