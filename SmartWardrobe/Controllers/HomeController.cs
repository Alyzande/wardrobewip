using SmartW.Services.IServices;
using SmartW.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartWardrobe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GetUserGarment(string UserID)
        {
            ViewBag.Message = "Your garments page.";

            return View();
        }
        private ISmartWService _SmartWService;
        public HomeController()
        {
            _SmartWService = new SmartWService();
        }
    }
}