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
        [ForeignKey("ResponsavelMesa")]
        public int idResponsavelMesa { get; set; }
        [ForeignKey("ResponsavelPalco")]
        public int idResponsavelPalco { get; set; }
        [ForeignKey("ResponsavelCozinha")]
        public int idResponsavelCozinha { get; set; }
        [ForeignKey("ResponsavelBebidas")]
        public int idResponsavelBebidas { get; set; }
        [ForeignKey("ResponsavelCaixas")]
        public int idResponsavelCaixas { get; set; }
        [ForeignKey("ResponsavelLixo")]
        public int idResponsavelLixo { get; set; }
        [ForeignKey("ResponsavelSeguranca")]
        public int idResponsavelSeguranca { get; set; }
        [ForeignKey("ResponsavelLimpeza")]
        public int idResponsavelLimpeza { get; set; }

        public virtual Membro ResponsavelMesa { get; set; }
        public virtual Membro ResponsavelPalco { get; set; }
        public virtual Membro ResponsavelCozinha { get; set; }
        public virtual Membro ResponsavelBebidas { get; set; }
        public virtual Membro ResponsavelCaixas { get; set; }
        public virtual Membro ResponsavelLixo { get; set; }
        public virtual Membro ResponsavelSeguranca { get; set; }
        public virtual Membro ResponsavelLimpeza { get; set; }

        #region Checklist

        public bool ClubeAgendado { get; set; }
        public bool ConfirmarNumeroMesas { get; set; }


        #endregion
    }
}
