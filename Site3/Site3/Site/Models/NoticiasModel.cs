using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class NoticiasModel
    {
        [Key]
        public int IDNoticia { get; set; }

        [Display(Name="Titulo")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres no campo Título")]
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }

        [Display(Name="Descrição")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres no campo Descrição")]
        [Required(ErrorMessage = "O campo Descricao é obrigatório ")]
        public string Descricao { get; set; }

        [Display(Name="Imagem")]
        public string Imagem { get; set; }

        [Display(Name="Data Noticia")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo Data da Noticia é obrigatório")]
        public DateTime DataNoticia { get; set; }
    }
}