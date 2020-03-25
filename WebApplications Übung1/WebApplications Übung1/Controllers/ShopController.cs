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

        public ActionResult Smartphone(int kategorie_id = 1)
        {
            List<Item>  items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetItemsByCategory(kategorie_id);
            rep.Close();

            return View(items);
        }

        public ActionResult Kleidung(int kategorie_id = 2)
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetItemsByCategory(kategorie_id);
            rep.Close();

            return View(items);
        }

        public ActionResult Gartenausstattung(int kategorie_id = 3)
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetItemsByCategory(kategorie_id);
            rep.Close();

            return View(items);
        }

        public ActionResult Werkzeug(int kategorie_id = 4)
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetItemsByCategory(kategorie_id);
            rep.Close();

            return View(items);
        }

        public ActionResult Spiele(int kategorie_id = 5)
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetItemsByCategory(kategorie_id);
            rep.Close();

            return View(items);
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