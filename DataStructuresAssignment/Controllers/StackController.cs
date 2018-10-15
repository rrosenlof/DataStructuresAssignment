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
            if (stackStruct != null)
            {
                ViewBag.Output = stackStruct;
            }

            return View();
        }

        // Add one
        public ActionResult IndexStack1()
        {
            iCounter++;
            if (ViewBag.Output != null)
            {
                stackStruct = ViewBag.Output;
            }

            stackStruct.Push("New Entry #" + (iCounter) + " ");
            ViewBag.Output = stackStruct;

            return View("IndexStack");
        }

        // Add huge list
        public ActionResult IndexStack2()
        {
            iCounter = 0;
            for (int x = 1; x <= 2000; x++)
            {
                iCounter++;
                stackStruct.Push("New Entry #" + x + " ");
            }
            ViewBag.Output = stackStruct;

            return View("IndexStack");
        }

        // Display
        public ActionResult IndexStack3()
        {
            if (stackStruct != null)
            {
                ViewBag.Output = stackStruct;
            }

            return View("IndexStack");
        }

        // Delete From
        public ActionResult IndexStack4()
        {
            if (stackStruct.Contains("New Entry #" + iCounter + " "))
            {
                stackStruct.Pop();

                iCounter--;
            }
            else
            {
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
            int iSearchNum = oRand.Next(iCounter + 1);

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            if (stackStruct.Contains("New Entry #" + iSearchNum + " "))
            {
                ViewBag.SearchResults = stackStruct.ElementAt(iSearchNum - 1);

            }
            else ViewBag.SearchResults = "Not Found";

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;

            ViewBag.Output = ViewBag.SearchResults + " - Searched in " + ViewBag.StopWatch;

            return View("IndexStack");
        }
        public ActionResult ReturnToMenu()
        {
            return new RedirectResult(Url.Action("Index", "Index"));
        }

    }
}