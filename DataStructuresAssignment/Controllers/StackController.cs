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
    public class StackController : Controller
    {
        public static Stack<string> stackStruct = new Stack<string>();
        public static int iCounter = 0;

        // GET: Stack
        public ActionResult IndexStack()
        {
            if (stackStruct.Count != 0)
            {
                ViewBag.Output = stackStruct;
            }

            return View();
        }

        // Add one
        public ActionResult IndexStack1()
        {
            stackStruct.Push(" Item " + ++iCounter + " ");
            
            return View("IndexStack");
        }

        // Add huge list
        public ActionResult IndexStack2()
        {
            for (int x = 0; x < 2000; x++)
            {
                stackStruct.Push(" Item " + ++iCounter + " ");
            }

            return View("IndexStack");
        }

        // Display
        public ActionResult IndexStack3()
        {
            if (stackStruct.Count != 0)
            {
                ViewBag.Output = stackStruct;
            }

            return View("IndexStack");
        }

        // Delete From
        public ActionResult IndexStack4()
        {
            if (stackStruct.Count != 0)
            {
                stackStruct.Pop();
                
            }
            else
            {
                ViewBag.Error = "Nothing to delete";

                iCounter = 0;
            }
            ViewBag.Output = stackStruct;

            return View("IndexStack");
        }

        // Clear
        public ActionResult IndexStack5()
        {
            stackStruct.Clear();

            iCounter = 0;

            return View("IndexStack");
        }

        // Search
        public ActionResult IndexStack6()
        {
            Random oRand = new Random();
            int iSearchNum = oRand.Next(1, (iCounter + 1));

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            if (stackStruct.Contains(" Item " + iSearchNum + " "))
            {
                ViewBag.SearchResults = stackStruct.ElementAt(iSearchNum - 1);

            }
            else ViewBag.SearchResults = "Not Found";

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;

            return View("IndexStack");
        }


    }
}