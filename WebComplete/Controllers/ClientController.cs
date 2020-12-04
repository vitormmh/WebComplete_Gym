using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebComplete.Models;
using System.Data.Entity;
using WebComplete.Models.ViewModel;

namespace WebComplete.Controllers
{
    public class ClientController : Controller
    {

        ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {

            List<Client> Clientes = _context.Client.Include(c => c.Plan).ToList();

            return View(Clientes);
        }

        public ActionResult IndexApi()
        {

            List<Client> ClientesApi = _context.Client.Include(c => c.Plan).ToList();

            return View(ClientesApi);
        }
 

        public ActionResult Delete(int Id)
        {
            var cli = _context.Client.Find(Id);
            if (cli == null)
            {
                return HttpNotFound();
            }
            _context.Client.Remove(cli);
            _context.SaveChanges();

            return RedirectToAction("Index", "Client");
        }




        public ActionResult New()
        {
            //Listar Plan , e _context para abri na db, mas para que isso aconteça há que instanciar a PlanUserViewModel porque Plano é um modelo diferente de Client e so podemos passar um modelo para a view 
            List<Plan> Planox = new List<Plan>();

            Planox = _context.Plan.ToList();

            PlanUserViewModel viewModel = new PlanUserViewModel()
            {
                 Cliente = new Client(),
                Planos = Planox,

            };

            ViewBag.Acao = "Novo Cliente";
            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Save(Client cliente)
        {

            if (cliente.Id == 0)
            {
                _context.Client.Add(cliente);
             
            }
            else
            {
                var cadaLinha = _context.Client.Single(s=>s.Id == cliente.Id );

                cadaLinha.Mail = cliente.Mail;
                cadaLinha.Name = cliente.Name;
                cadaLinha.BirthDate = cliente.BirthDate;
                cadaLinha.SubscribeDate = cliente.SubscribeDate;
                cadaLinha.IsSubscrivedToNews = cliente.IsSubscrivedToNews;



            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Client");
        }
      
        
        
        
        
        // Edit a variavel client via encontar um id ja criado , depois da validação  
        public ActionResult Edit(int Id)
        {
            var client = _context.Client.Find(Id);
            if(client == null)
            {
                return HttpNotFound();

            }
            List<Plan> Planox = new List<Plan>();

            Planox = _context.Plan.ToList();

            var  viewModel = new PlanUserViewModel()
            {
                Planos = Planox,
                Cliente = client

            };
            ViewBag.Acao = "Editar Cliente";
            return View("New",viewModel);
        }
    }
}