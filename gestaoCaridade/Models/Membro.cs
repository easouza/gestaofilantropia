using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace gestaoCaridade.Models
{
    public class Membro : IdentityUser
    {
        [Key]
        public int IdMembro { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Cargo { get; set; }
        [Display(Name ="Data de entrada")]
        public DateTime DataEntrada { get; set; }
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
