using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Documento
    {
        [Key]
        public int IdDocumento { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de Inserção")]
        public DateTime DataInsercao { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime DataAtualizacao { get; set; }
    }
}
