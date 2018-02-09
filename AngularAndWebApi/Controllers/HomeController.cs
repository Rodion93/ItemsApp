using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularAndWebApi.Controllers
{
    /// <summary>
    /// Main controller for views
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// To page Items
        /// </summary>
        /// <returns>Page Items</returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        /// <summary>
        /// To page Statistic
        /// </summary>
        /// <returns>Page Statistic</returns>
        public ActionResult Statistic()
        {
            ViewBag.Title = "Statistic";

            return View();
        }
    }
}
