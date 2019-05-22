using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "App");
            }
            else
            {
                return View();
            }

        }

        public ActionResult LoginLanding()
        {

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "App");
            }
            else
            {
                return View();
            }

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