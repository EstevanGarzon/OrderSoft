using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderSoftV0.Models
{
    public class Index
    {
        [Required]
        [StringLength(16)]
        [Display(Name ="Usuario")]
        public string user { get; set; }
        [Required]
        [StringLength(16)]
        [Display(Name ="Contraseña")]
        public string password { get; set; }

    }
}