using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class DictionaryController : Controller
    {
        Dictionary<string, int> dictStruct = new Dictionary<string, int>();

        // GET: Dictionary
        public ActionResult IndexDictionary()
        {

            if (dictStruct != null)
            {
                ViewBag.Output1 = dictStruct;
            }
            if (dictStruct != null)
            {
                ViewBag.Output2 = dictStruct;
            }
            return View();
        }

        public ActionResult IndexDictionary1()
        {
            dictStruct.Add("test", -1);

            if(dictStruct != null)
            {
                ViewBag.Output1 = dictStruct;
            }
            
            return View("IndexDictionary");
        }

        public ActionResult IndexDictionary2()
        {
            for(int x = 0; x < 2000; x++)
            {
                dictStruct.Add("test", x+1);
            }

            if(dictStruct != null)
            {
                ViewBag.Output2 = dictStruct;
            }
            return View("IndexDictionary");
        }


    }
}