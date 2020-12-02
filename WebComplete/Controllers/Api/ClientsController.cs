using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using WebComplete.Models;

namespace WebComplete.Controllers.Api
{
    public class ClientsController : ApiController
    {
        private ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }


        // Get /Api/Clients 
        
        public IEnumerable<Client> GetClient()
        {
            return _context.Client.ToList();
        }

        //Get /api/Clients/1
     
        public Client GetClient(int Id)
        {
            var cliente = _context.Client.SingleOrDefault(c => c.Id == Id);
            if (cliente == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }
            else { return cliente; }
         
        }

     // POST /Api/Clients
     [HttpPost]
        public Client CreateClient(Client cliente)
        {
            if (!ModelState.IsValid)
             throw new HttpResponseException(HttpStatusCode.BadRequest); 
            
                _context.Client.Add(cliente);
                _context.SaveChanges();

            return cliente;

        }

         //PUT /Api/Clients
        [HttpPut]

        public void UpdateClient(int id, Client cliente)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var clientIntId = _context.Client.SingleOrDefault(c => c.Id == id);
            // clientIntdb o meu cliente na base de dados 

            if (clientIntId != null)
            {
                clientIntId.Name = cliente.Name;
                clientIntId.Mail = cliente.Mail;
                clientIntId.PlanID = cliente.PlanID;
                clientIntId.BirthDate = cliente.BirthDate;

                _context.SaveChanges();

            }
             throw new HttpResponseException(HttpStatusCode.NotFound);

        }


        //DELETE /api/Clients/1
        [HttpDelete]
        public void DeleteClient(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var clientId = _context.Client.SingleOrDefault(c => c.Id == id);

            _context.Client.Remove(clientId);

            _context.SaveChanges();
        }

    }
}
