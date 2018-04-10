using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gestaoCaridade.Models
{
    public class Membro
    {
        [Key]
        public int IdMembro { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }
        public string Cargo { get; set; }
        [Display(Name ="Data de entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [Required]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public String Password { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
