using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data de Nascimento")]
        public string DataNascimento { get; set; }
    }
}
