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
        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }
        [Display(Name = "Vendedor")]
        [ForeignKey("VendedorResponsavel")]
        public int IdVendedor { get; set; }
        [Display(Name = "Evento")]
        [ForeignKey("EventoIngresso")]
        public int IdEvento { get; set; }

        [Display(Name = "Vendedor")]
        public virtual Vendedor VendedorResponsavel { get; set; }
        [Display(Name = "Evento")]
        public virtual Evento EventoIngresso { get; set; }
    }
}
