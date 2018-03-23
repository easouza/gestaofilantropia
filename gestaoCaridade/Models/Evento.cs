using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Local { get; set; }
        [Required]
        public DateTime Data { get; set; }

        [ForeignKey("ResponsavelEvento")]
        public int IdResponsavel { get; set; }

        public virtual Responsavel ResponsavelEvento { get; set; }
    }
}
