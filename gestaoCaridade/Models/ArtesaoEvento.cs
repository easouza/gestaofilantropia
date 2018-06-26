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
        [Display(Name = "Artesão")]
        public int IdArtesao { get; set; }
        [Required]
        [ForeignKey("EventoVinculado")]
        [Display(Name ="Evento")]
        public int IdEvento { get; set; }

        [Display(Name ="Valor Vendido")]
        public float ValorVendido { get; set; }

        [Display(Name ="Comissão do Artesão")]
        public float ComissaoArtesao { get; set; }

        [Display(Name = "Artesão")]
        public virtual Artesao ArtesaoSelecionado { get; set; }
        [Display(Name = "Evento")]
        public virtual Evento EventoVinculado { get; set; }
    }
}
