using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComplete.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult CorreiosCalc(string cep)
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}