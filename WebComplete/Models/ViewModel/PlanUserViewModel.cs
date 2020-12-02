using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebComplete.Models.ViewModel
{
    public class PlanUserViewModel
    {
        public Client Cliente { get; set; }
        public List<Plan> Planos { get; set; }
        public List<Plan2> PlanoA { get; set; }
    }
}