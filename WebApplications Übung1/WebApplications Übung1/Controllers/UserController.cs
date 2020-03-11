using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplications_Übung1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult login()
        {
            return View();
        }
        public ActionResult registration()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }
    }
}