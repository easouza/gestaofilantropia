using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gestaoCaridade.Models
{
    public class Membro
    {
        [Key]
        public int IdMembro { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name = "Data de Iniciação")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }
        [Required]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }
        public string LugarNascimento { get; set; }
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string UF { get; set; }
        public string DocIdentidade { get; set; }
        public string CPF { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UFEndereco { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public string DataCasamento { get; set; }
        public string TipoSanguineo { get; set; }
        public string NomeEsposo { get; set; }
        public DateTime DatNascEsposo { get; set; }
        public string NomeFilho1 { get; set; }
        public string DatNascFilho1 { get; set; }

        public string Empresa { get; set; }
        public string ProfissaoCargo { get; set; }
        public string CnpjCpf { get; set; }
        public string InscricaoEstadual { get; set; }
        public string EnderecoEmpresa { get; set; }
        public string NumeroEmpresa { get; set; }
        public string ComplementoEmpresa { get; set; }
        public string BairroEmpresa { get; set; }
        public string CidadeEmpresa { get; set; }
        public string UfEmpresa { get; set; }
        public string CepEmpresa { get; set; }
        public string TelefoneEmpresa { get; set; }
        public string FaxEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string InfoImportantes { get; set; }
        public string AfastamentoSaida { get; set; }
        public string DataSaida { get; set; }
        [Required]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public String Password { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
