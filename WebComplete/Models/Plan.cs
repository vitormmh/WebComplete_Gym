using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebComplete.Models
{
    public class Plan
    {
        public int Id { get; set; }
        [Required]
        [StringLength (120)]
        public string Name{ get; set; }
        public float Value { get; set; }

    }
}