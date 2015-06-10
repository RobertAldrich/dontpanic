using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using dontpanic.Models;

namespace dontpanic.Controllers
{
    public class CalculatorController : Controller
    {
        // 
        // GET: /Calculator/ 

        public ActionResult Index(string mathOperation)
        {
            
            return View();

        }

        public ActionResult Evaluate (Calculation calcModel)
        {

            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double),calcModel.mathOperation );
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return Json(loDataTable.Rows[0]["Eval"], JsonRequestBehavior.AllowGet);

        }

        // 
        // GET: /Calculator/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }


    }
}