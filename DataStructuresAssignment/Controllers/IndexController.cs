/*IS 403 Data Structures Assignment
    Ross Rosenlof, Trevan Reese, Caden Dortch, Ryan Jenks
    This website shows how three data
    structures - stacks, dictionaries, and queues,
    handle data and output them to a view.-*/

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