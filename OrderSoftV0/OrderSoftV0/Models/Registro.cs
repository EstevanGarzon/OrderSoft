using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderSoftV0.Models
{
    public class Registro
    {
        [Required]
        [Display(Name = "Primer nombre")]
        public string nombre1 { get; set; }
        [Display(Name = "Segundo nombre")]
        public string nombre2 { get; set; }
        [Required]
        [Display(Name = "Primer apellido")]
        public string apellido1 { get; set; }
        [Display(Name = "Segundo apellido")]
        public string apellido2 { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        public string cedula { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public string ciudad { get; set; }

    }
}