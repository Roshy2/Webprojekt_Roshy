using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplications_Übung1.Models;
using WebApplications_Übung1.Models.db;

namespace WebApplications_Übung1.Controllers
{
    public class ShopController : Controller
    {
        IRepositoryItem rep;
        // GET: Shop
        public ActionResult Index()
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetAllItem();
            rep.Close();

            return View(items);
        }

        public ActionResult Smartphone()
        {
            return View();
        }

        public ActionResult Kleidung()
        {
            return View();
        }

        public ActionResult Gartenausstattung()
        {
            return View();
        }

        public ActionResult Werkzeug()
        {
            return View();
        }

        public ActionResult Spiele()
        {
            return View();
        }

        public ActionResult AllArticels()
        {
            return View();
        }
        public ActionResult Warenkorb()
        {
            return View();
        }
    }
}