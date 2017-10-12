using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class ContatoModel
    {
        [Key]
        public int IDContato { get; set; }

        [DisplayName("Nome")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres no campo Nome!")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeContato { get; set; }

        [DisplayName("E-mail")]
        [StringLength(50)]
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string EmailContato { get; set; }

        [DisplayName("Mensagem")]
        [StringLength(300, ErrorMessage = "Máximo de 300 caracteres!")]
        [Required(ErrorMessage = "O campo Mensagem é obrigatório")]
        public string Mensagem { get; set; }
    }
}