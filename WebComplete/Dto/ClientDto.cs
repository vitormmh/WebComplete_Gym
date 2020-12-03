using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebComplete.Models;

namespace WebComplete.Dto
{
    public class ClientDto
    {

        public int Id { get; set; }
        //Data Notations - tipo de validação 
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Mail { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime SubscribeDate { get; set; }
        public Plan Plan { get; set; }
        public int PlanID { get; set; }




    }
}