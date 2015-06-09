using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dontpanic.Controllers
{
    public class CalculatorController : Controller
    {
        // 
        // GET: /Calculator/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Calculator/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }


    }
}