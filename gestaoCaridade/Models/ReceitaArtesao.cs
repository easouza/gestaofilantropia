using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class ReceitaArtesao
    {
        [Key]
        public int IdReceitaArtesao { get; set; }
        [Required]
        public double Valor { get; set; }
        public double Comissao { get; set; }
    }
}
