using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class ArtesaoEvento
    {
        [Key]
        public int IdArtesaoEvento { get; set; }
        [Required]
        [ForeignKey("ArtesaoSelecionado")]
        public int IdArtesao { get; set; }
        [Required]
        [ForeignKey("EventoVinculado")]
        public int IdEvento { get; set; }

        public virtual Artesao ArtesaoSelecionado { get; set; }
        public virtual Evento EventoVinculado { get; set; }
    }
}
