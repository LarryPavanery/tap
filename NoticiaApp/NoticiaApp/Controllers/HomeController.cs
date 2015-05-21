using NoticiaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoticiaApp.Controllers
{
    public class HomeController : Controller
    {

        private DBContext db = new DBContext();

        public ActionResult Index()
        {
            return View(db.Noticias.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}