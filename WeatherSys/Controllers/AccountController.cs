using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherSys.EntityModel;

namespace WeatherSys.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult AdminIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users users)
        {
            if (ModelState.IsValid)
            {
                using (weatherEntities db = new weatherEntities())
                {
                    db.Users.Add(users);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Account");
                }
            }
            return View(users);
        }

    }
}
