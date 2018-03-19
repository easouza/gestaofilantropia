using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        [Required]
        public string Tipo { get; set; }
        public double Valor { get; set; }
        [Required]
        public DateTime DataAquisicao { get; set; }
    }
}
