using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class StackController : Controller
    {
        // GET: Stack
        public ActionResult IndexStack()
        {
            return View();
        }

        /*Methods for each one in the list*/
        public ActionResult StackReturn() /* Exit, redirects to BYU.edu*/
        {
            return new RedirectResult(Url.Action("Index", "Index"));
        }
    }
}