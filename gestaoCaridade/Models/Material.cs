using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestaoCaridade.Models
{
    public class Material
    {
        [Key]
        public int IDMaterial { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public double Valor { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data de Aquisição")]
        public DateTime DataAquisicao { get; set; }
        [ForeignKey("EventoSelecionado")]
        [Display(Name ="Evento")]
        public int IdEvento { get; set; }

        [Display(Name = "Evento")]
        public virtual Evento EventoSelecionado { get; set; }
    }
}
