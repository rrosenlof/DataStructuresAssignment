using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult IndexDictionary()
        {

            return View();
        }

        public ActionResult IndexDictionary1()
        {
            Dictionary<string, int> dictStruct = new Dictionary<string, int>();
            dictStruct.Add("string", 1);

            ViewBag.Output = dictStruct;
            return View();
        }


    }
}