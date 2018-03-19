using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public DateTime DataAquisicao { get; set; }
    }
}
