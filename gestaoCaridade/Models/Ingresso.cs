using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ICollection<Vendedor> Vendedor { get; set; }
        [Required]
        public ICollection<Evento> Evento { get; set; }
    }
}
