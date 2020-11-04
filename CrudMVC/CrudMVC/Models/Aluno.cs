using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudMVC.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        [MaxLength(200)]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "")]
        public DateTime Nascimento { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}