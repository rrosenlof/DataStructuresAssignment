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
            stackStruct.Clear();

            stackStruct.Push("TEST CHOICE " + iCounter);

            iCounter++;

            return View("IndexStack");
        }

        // Add huge list
        public ActionResult IndexStack2()
        {
            stackStruct.Clear();

            int stackLength = stackStruct.Count + 1;

            for (int x = 0; x < 2000; x++)
            {
                stackStruct.Push("test " + (stackLength + x));
            }

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
            stackStruct.Pop();

            return View("IndexStack");
        }

        // Clear
        public ActionResult IndexStack5()
        {
            stackStruct.Clear();

            return View("IndexStack");
        }

        // Search
        public ActionResult IndexStack6()
        {
            if (stackStruct != null)
            {
                ViewBag.Output = stackStruct;
            }

            return View("IndexStack");
        }

    }
}