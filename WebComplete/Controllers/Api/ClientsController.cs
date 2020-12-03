using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using WebComplete.Models;
using WebComplete.Dto;
using AutoMapper;

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

        //Select não é um metodo por isso não é Client.ClientDto(), mas é um delegate - permite que você faça referência a um método
        public IEnumerable<ClientDto> GetClient()
        {
            return _context.Client.ToList().Select(Mapper.Map<Client, ClientDto>);
        }

        //Get /api/Clients/1
     
        //public ClientDto GetClient(int Id)
        public IHttpActionResult GetClient(int Id)
        {
            var cliente = _context.Client.SingleOrDefault(c => c.Id == Id);
            if (cliente == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            else
            {
                //  return Mapper.Map<Client,ClientDto>(cliente);
                return Ok(Mapper.Map<Client, ClientDto>(cliente));
            }
         
        }

     // POST /Api/Clients
     [HttpPost]
        public ClientDto CreateClient(ClientDto clienteDto)
        {
            if (!ModelState.IsValid)
             throw new HttpResponseException(HttpStatusCode.BadRequest);
            var client = Mapper.Map<ClientDto, Client>(clienteDto);

            //como a inserçao vem do lado do ClientDto então temos que criar um Id
            clienteDto.Id = client.Id;

            _context.Client.Add(client);
            _context.SaveChanges();

            return clienteDto;

        }

         //PUT /Api/Clients
        [HttpPut]

        public void UpdateClient(int id, Client clienteDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var clientIntId = _context.Client.SingleOrDefault(c => c.Id == id);
            // clientIntdb o meu cliente na base de dados 
            //o mapeamento é direto porque se trata de um update 
            if (clientIntId != null)
            {
                Mapper.Map(clienteDto, clientIntId);
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
