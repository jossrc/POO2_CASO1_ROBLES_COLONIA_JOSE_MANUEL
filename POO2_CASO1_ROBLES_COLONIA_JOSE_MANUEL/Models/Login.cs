using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Models
{
    public class Login
    {
        [Display(Name = "Nombre del usuario")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Clave del usuario")]
        [Required]
        public string Password { get; set; }
    }
}