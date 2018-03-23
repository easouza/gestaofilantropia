using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestaoCaridade.Models
{
    public class Doacao
    {
        [Key]
        public int IdDoacao { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Origem { get; set; }
        [ForeignKey("DoadorSelecionado")]
        public int IdDoador { get; set; }
        [ForeignKey("EventoSelecionado")]
        public int IdEvento { get; set; }

        public virtual Doador DoadorSelecionado { get; set; }
        public virtual Evento EventoSelecionado { get; set; }
    }
}
