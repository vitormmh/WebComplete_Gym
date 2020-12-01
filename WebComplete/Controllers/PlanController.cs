using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebComplete.Models;

namespace WebComplete.Controllers
{
    public class PlanController : Controller
    {

        ApplicationDbContext _context;

        public PlanController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {

            List<Plan> Planos = _context.Plan.ToList();

            return View(Planos);

        }

        public ActionResult Edit(int PlanoId,string Nome, int num)
        {

            return Content("PlanoId="+ PlanoId, "Nome =" + Nome); 
        }
    }
}