using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class NoticiasModel
    {
        [Key]
        public int Codigo { get; set; }
        //[ForeignKey]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}