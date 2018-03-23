using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class EventoCliente
    {
        [Key]
        public int IdEventoCliente { get; set; }
        [Required]
        [ForeignKey("ClienteSelecionado")]
        public int IdCliente { get; set; }
        [Required]
        [ForeignKey("EventoSelecionado")]
        public int IdEvento { get; set; }

        public virtual Cliente ClienteSelecionado { get; set; }
        public virtual Evento EventoSelecionado { get; set; }
    }
}
