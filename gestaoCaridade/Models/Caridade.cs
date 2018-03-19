using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Caridade
    {
        [Key]
        public int IdCaridade { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public string Endereco { get; set; }
    }
}
