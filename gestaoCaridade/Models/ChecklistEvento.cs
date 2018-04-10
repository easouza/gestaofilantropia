using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class ChecklistEvento
    {
        [Key]
        public int IDChecklist { get; set; }
        [Display(Name ="Evento")]
        [ForeignKey("EventoVinculado")]
        public int IDEvento { get; set; }
        [Display(Name ="Local Reservado")]
        public bool ReservaLocal { get; set; }

        public virtual Evento EventoVinculado { get; set; }
    }
}
