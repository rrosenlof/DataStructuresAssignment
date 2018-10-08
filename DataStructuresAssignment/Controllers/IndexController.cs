using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BYU() /* Exit, redirects to BYU.edu*/
        {
            return new RedirectResult("https://www.byu.edu");
        }
    }
}