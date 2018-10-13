using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class DictionaryController : Controller
    {
        // Declare public static variables to be used for each method
        public static Dictionary<string, int> dictStruct = new Dictionary<string, int>();
        public static int iCounter = 0;

        // GET: Dictionary
        public ActionResult IndexDictionary() // Displays output to ViewBag, default
        {
            if (dictStruct != null)
            {
                ViewBag.Output = dictStruct;                
            }

            return View();
        }

        public ActionResult IndexDictionary1() // Adds one item to the end of the dictionary
        {
            iCounter++;
            dictStruct.Add(" Item " + iCounter +" - ", iCounter);

            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary2() // Adds 2000 items to the end of the dictionary
        {
            int x = 0;
            while(x < 2000)
            {
                iCounter++;
                dictStruct.Add(" Item " +  iCounter + " - ", iCounter);
                x++;
            }
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary3() // Displays dictionary
        {
            if (dictStruct != null)
            {
                ViewBag.Output = dictStruct;
            }

            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary4() // Removes last item in the dictionary
        {
            if(dictStruct.ContainsKey(" Item " + iCounter + " - "))
            {
                dictStruct.Remove(" Item " + iCounter + " - ");

                iCounter--;
            }

            else // If there are no items in the dictionary, nothing is deleted
            {
                //print cannot delete

                iCounter = 0;
            }
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary5() // Clears contents of the dictionary
        {
            dictStruct.Clear();

            iCounter = 0;

            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary6() // Search
        {
            Random randNum = new Random();
            int iRandKeyIndex = randNum.Next(1, (iCounter+1)); // Generates a random number in the range of the dictionary contents

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            if (dictStruct.ContainsKey(" Item " + iRandKeyIndex + " - "))
            {
                ViewBag.SearchResults = dictStruct[" Item " + iRandKeyIndex + " - "];
            }

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;
            
            return View("IndexDictionary");
        }


    }
}