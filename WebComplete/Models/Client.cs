using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebComplete.Models
{
    public class Client
    {
        public int Id  { get; set; }
        //Data Notations - tipo de validação 
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Mail { get; set; }

      
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

   
        [Display(Name = "Data de Inscrição")]
        public DateTime SubscribeDate { get; set; }

        public bool  IsSubscrivedToNews { get; set; }
       
        public Plan Plan { get; set; }
        public int PlanID { get; set; }
    }
}