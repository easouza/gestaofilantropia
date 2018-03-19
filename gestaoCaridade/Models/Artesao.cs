using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Artesao
    {
        [Key]
        public int IdArtesao { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Profissao { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
