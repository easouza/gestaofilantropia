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
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [ForeignKey("MembroEvento")]
        [Display(Name ="Membro")]
        public int IdMembro { get; set; }

        #region Checklist

        public bool ClubeAgendado { get; set; }
        public bool ConfirmarNumeroMesas { get; set; }


        #endregion

        [Display(Name = "Responsável")]
        public virtual Membro MembroEvento { get; set; }
    }
}
