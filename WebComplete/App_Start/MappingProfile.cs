using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebComplete.Dto;
using WebComplete.Models;

namespace WebComplete.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Client, ClientDto>();
            Mapper.CreateMap<ClientDto,Client>();
        }

    }
}