using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelUp.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return Login();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
    }
}