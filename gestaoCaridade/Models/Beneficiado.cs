using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Beneficiado
    {
        [Key]
        public int IDBeneficiado { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [Display(Name ="Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
