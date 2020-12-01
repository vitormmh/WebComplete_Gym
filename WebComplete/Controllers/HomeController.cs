using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebComplete.Models;
using WebComplete.Models.ViewModel;

namespace WebComplete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Client user = new Client();
            user.Name = "Vitor";


            var ListPlan = new List<Plan>()
            {
                new Models.Plan() {Id=1,Name="Plano 1", Value=100},
                new Models.Plan() {Id=2, Name="Plano 2", Value=200 }
            };

            var ListPlan2 = new List<Plan2>()
            {
                new Models.Plan2() {Id=1,Name="Plano A", Modalidade="Futebol", Value=100},
                new Models.Plan2() {Id=2, Name="Plano B",Modalidade="Natação", Value=200 }
            };

            PlanUserViewModel model = new PlanUserViewModel();

            model.cliente = user;
            model.Planos = ListPlan;
            model.PlanoA = ListPlan2;

            return View(model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}