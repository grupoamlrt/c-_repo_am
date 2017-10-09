using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class AdmModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}