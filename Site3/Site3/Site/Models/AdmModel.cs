using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class AdmModel
    {
        [Key]
        public int IDAdmin { get; set; }

        [Display(Name = "Nome")]
        [StringLength(30, ErrorMessage = "Máximo 40 caracteres no campo Nome!")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [StringLength(30, ErrorMessage = "Máximo 20 caracteres no campo CPF!")]
        [Required]
        public string CPF { get; set; }

        [Display(Name = "Logradouro")]
        [StringLength(30, ErrorMessage = "Máximo 50 caracteres no campo Logradouro!")]
        public string Logradouro { get; set; }

        [Display(Name = "E-mail *")]
        [StringLength(30)]
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Display(Name = "Data Nascimento *")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Senha *")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres no campo Senha!")]
        [Required]
        public string Senha { get; set; }

        public bool Status_Adm { get; set; }
    }
}