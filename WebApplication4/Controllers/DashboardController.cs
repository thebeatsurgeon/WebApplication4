using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class dashboardcontroller : Controller
    {
        // GET: dashboardcontroller
        public ActionResult Index()
        {
            return View();
        }
    }
}