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
            iCounter++;
            dictStruct.Add(" TEST CHOICE " + iCounter +" - ", iCounter);

            
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary2()
        {
            int x = 0;
            while(x < 2000)
            {
                iCounter++;
                dictStruct.Add(" test " +  iCounter + " - ", iCounter);
                x++;
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
            if(dictStruct.ContainsKey(" test " + iCounter + " - "))
            {
                dictStruct.Remove(" test " + iCounter + " - ");

                iCounter--;
            }

            else if(dictStruct.ContainsKey(" TEST CHOICE " + iCounter + " - "))
            {
                dictStruct.Remove(" TEST CHOICE " + iCounter  + " - ");

                iCounter--; 
            }

            else
            {
                //print cannot delete

                iCounter = 0;
            }
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary5()
        {
            dictStruct.Clear();

            return View("IndexDictionary");
        }


    }
}