using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Caridade
    {
        [Key]
        public int IdCaridade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        [ForeignKey("BeneficiadoSelecionado")]
        [Display(Name ="Beneficiado")]
        public int IdBeneficiado { get; set; }
        [ForeignKey("ItemSelecionado")]
        [Display(Name ="Item")]
        public int IdItem { get; set; }

        [Display(Name = "Beneficiado")]
        public virtual Beneficiado BeneficiadoSelecionado { get; set; }
        [Display(Name = "Item")]
        public virtual Item ItemSelecionado { get; set; }
    }
}
