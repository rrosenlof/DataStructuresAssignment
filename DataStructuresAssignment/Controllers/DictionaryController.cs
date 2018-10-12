using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class DictionaryController : Controller
    {
        public static Dictionary<string, int> dictStruct = new Dictionary<string, int>();
        public static int iCounter = 0;
        // GET: Dictionary
        public ActionResult IndexDictionary()
        {
            if (dictStruct != null)
            {
                ViewBag.Output = dictStruct;                
            }

            return View();
        }

        public ActionResult IndexDictionary1()
        {
            dictStruct.Add("TEST CHOICE " + iCounter, -1);

            iCounter++;
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary2()
        {
            int dictLength = dictStruct.Count + 1;

            for(int x = 0; x < 2000; x++)
            {
                dictStruct.Add("test " + (dictLength + x), x+1);
            }
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary3()
        {
            if (dictStruct != null)
            {
                ViewBag.Output = dictStruct;
            }

            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary4()
        {
            if(dictStruct.ContainsKey("test " + iCounter))
            {
                dictStruct.Remove("test " + iCounter);

                iCounter--;
            }

            else if(dictStruct.ContainsKey("TEST CHOICE " + iCounter))
            {
                dictStruct.Remove("TEST CHOICE " + iCounter);

                iCounter--; 
            }

           
         

            return View("IndexDictionary");
        }


    }
}