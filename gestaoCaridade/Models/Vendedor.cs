using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Vendedor
    {
        [Key]
        public int IdVendedor { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }
        public string Telefone { get; set; }
    }
}
