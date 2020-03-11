using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplications_Übung1.Models;
using WebApplications_Übung1.Models.db;

namespace WebApplications_Übung1.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryItem rep;
        //GET: Home
        public ActionResult Index()
        {
            List<Item> items;
            rep = new RepositoryItemDB();
            rep.Open();
            items = rep.GetAllItem();
            rep.Close();

            return View(items);
        }
       
    }
}