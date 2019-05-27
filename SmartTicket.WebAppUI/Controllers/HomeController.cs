using SmartTicket.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartTicket.WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        private CategoryManager cm = new CategoryManager();
        // GET: Home
        public ActionResult Index()
        {
            //deneme
            var x = cm.List();
            return View();
        }
    }
}