using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Responsavel
    {
        [Key]
        public int IdResponsavel { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
