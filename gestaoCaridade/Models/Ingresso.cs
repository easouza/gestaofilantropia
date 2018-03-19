using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Ingresso
    {
        [Key]
        public int IdIngresso { get; set; }
        [Required]
        public double Valor { get; set; }
        public DateTime DataVenda { get; set; }
        [ForeignKey("VendedorResponsavel")]
        public int IdVendedor { get; set; }

        [ForeignKey("EventoIngresso")]
        public int IdEvento { get; set; }

        public virtual Vendedor VendedorResponsavel { get; set; }

        public virtual Evento EventoIngresso { get; set; }
    }
}
