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
    public class QueueController : Controller
    {
        public static Queue<string> queStruct = new Queue<string>();
        public static int iCounter = 0;

        // GET: Queue
        public ActionResult IndexQueue()
        {
            if (queStruct.Count != 0)
            {
                ViewBag.Output = queStruct;
            }

            return View();
        }

        // Add one
        public ActionResult IndexQueue1()
        {
            queStruct.Enqueue(" Item " + ++iCounter + " ");
            
            return View("IndexQueue");
        }

        // Add huge list
        public ActionResult IndexQueue2()
        {
            for (int x = 0; x < 2000; x++)
            {
                queStruct.Enqueue(" Item " + ++iCounter + " ");
            }

            return View("IndexQueue");
        }

        // Display
        public ActionResult IndexQueue3()
        {
            if (queStruct.Count != 0)
            {
                ViewBag.Output = queStruct;
            }

            return View("IndexQueue");
        }

        // Delete From
        public ActionResult IndexQueue4()
        {
            if (queStruct.Count != 0)
            {
                queStruct.Dequeue();
                iCounter--;
            }

            else
            {
                ViewBag.Error = "Nothing to delete";

                iCounter = 0;
            }

            return View("IndexQueue");
        }

        // Clear
        public ActionResult IndexQueue5()
        {
            queStruct.Clear();

            iCounter = 0;

            return View("IndexQueue");
        }

        // Search
        public ActionResult IndexQueue6()
        {
            Random oRand = new Random();
            int iSearchNum = oRand.Next(1,(iCounter + 1));

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            if (queStruct.Contains(" Item " + iSearchNum + " "))
            {
                ViewBag.SearchResults = queStruct.ElementAt(iSearchNum - 1);

            }
            else ViewBag.SearchResults = "Not Found";

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;

            return View("IndexQueue");
        }

        
    }
}