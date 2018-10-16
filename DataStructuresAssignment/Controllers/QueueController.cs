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
            if (queStruct != null)
            {
                ViewBag.Output = queStruct;
            }

            return View();
        }

        // Add one
        public ActionResult IndexQueue1()
        {
            queStruct.Clear();

            queStruct.Enqueue("TEST CHOICE " + iCounter);

            iCounter++;

            return View("IndexQueue");
        }

        // Add huge list
        public ActionResult IndexQueue2()
        {
            queStruct.Clear();

            int queLength = queStruct.Count + 1;

            for (int x = 0; x < 2000; x++)
            {
                queStruct.Enqueue("test " + (queLength + x));
            }

            return View("IndexQueue");
        }

        // Display
        public ActionResult IndexQueue3()
        {
            if (queStruct != null)
            {
                ViewBag.Output = queStruct;
            }

            return View("IndexQueue");
        }

        // Delete From
        public ActionResult IndexQueue4()
        {
            if (queStruct != null)
            {
                queStruct.Dequeue();
            }

            return View("IndexQueue");
        }

        // Clear
        public ActionResult IndexQueue5()
        {
            queStruct.Clear();

            return View("IndexQueue");
        }

        // Search
        public ActionResult IndexQueue6()
        {
            if (queStruct != null)
            {
                ViewBag.Output = queStruct;
            }

            return View("IndexQueue");
        }

        
    }
}