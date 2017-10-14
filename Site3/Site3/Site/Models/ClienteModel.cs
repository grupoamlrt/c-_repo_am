using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class ClienteModel
    {
        [Key]
        public int IDCliente { get; set; }

        [Display(Name = "Nome")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres no campo Nome!")]
        [Required]
        public string Nome { get; set; }


        [Display(Name = "CPF")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres no campo CPF!")]
        [Required]
        public string CPF { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(30)]
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres no campo Cidade!")]
        [Required]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres no campo Estado!")]
        [Required]
        public string Estado { get; set; }

        [Display(Name = "Rua")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres no campo Rua!")]
        [Required]
        public string Rua { get; set; }

        [Display(Name = "CEP")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres no campo CEP!")]
        [Required]
        public string CEP { get; set; }

        [Display(Name = "Data Nascimento *")]
        [DataType(DataType.Date)]
        [Required]
        public DataType DataNascimento { get; set; }

        [Display(Name = "Senha *")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres no campo Senha!")]
        [Required]
        public string Senha { get; set; }

    }
}