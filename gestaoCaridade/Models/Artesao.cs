﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestaoCaridade.Models
{
    public class Artesao
    {
        [Key]
        public int IdArtesao { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name ="Profissão")]
        public string Profissao { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        [Display(Name ="Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true,ConvertEmptyStringToNull = true)]
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
