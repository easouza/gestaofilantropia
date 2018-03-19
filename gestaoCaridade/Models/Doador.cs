using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Doador
    {
        [Key]
        public int IdDoador { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string DataEntrada { get; set; }
        public string Telefone { get; set; }
    }
}
