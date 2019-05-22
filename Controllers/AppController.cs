using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class AppController : Controller
    {

        public ActionResult Dashboard()
        {
            return View();
        }

    }
}