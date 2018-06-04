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
        [Display(Name = "Local Nascimento")]
        public string LugarNascimento { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string UF { get; set; }
        [Display(Name = "RG")]
        public string DocIdentidade { get; set; }
        public string CPF { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Número")]
        public string NumeroEndereco { get; set; }
        [Display(Name = "Complemento")]
        public string ComplementoEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        [Display(Name = "UF")]
        public string UFEndereco { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }
        [Display(Name = "Data do casamento")]
        [DataType(DataType.Date)]
        public DateTime DataCasamento { get; set; }
        [Display(Name = "Tipo sanguíneo")]
        public string TipoSanguineo { get; set; }
        [Display(Name = "Nome do esposo")]
        public string NomeEsposo { get; set; }
        [Display(Name = "Data de nascimento do esposo")]
        [DataType(DataType.Date)]
        public DateTime DatNascEsposo { get; set; }
        [Display(Name = "Nome do Filho")]
        public string NomeFilho1 { get; set; }
        [Display(Name = "Data de Nascimento do filho")]
        [DataType(DataType.Date)]
        public string DatNascFilho1 { get; set; }

        public string Empresa { get; set; }
        [Display(Name = "Profissão/Cargo")]
        public string ProfissaoCargo { get; set; }
        [Display(Name = "CNPJ/CPF")]
        public string CnpjCpf { get; set; }
        [Display(Name = "Inscricão Estadual")]
        public string InscricaoEstadual { get; set; }
        [Display(Name = "Endereço")]
        public string EnderecoEmpresa { get; set; }
        [Display(Name = "Número")]
        public string NumeroEmpresa { get; set; }
        [Display(Name = "Compl.")]
        public string ComplementoEmpresa { get; set; }
        [Display(Name = "Bairro")]
        public string BairroEmpresa { get; set; }
        [Display(Name = "Cidade")]
        public string CidadeEmpresa { get; set; }
        [Display(Name = "UF")]
        public string UfEmpresa { get; set; }
        [Display(Name = "CEP")]
        public string CepEmpresa { get; set; }
        [Display(Name = "Telefone")]
        public string TelefoneEmpresa { get; set; }
        [Display(Name = "FAX")]
        public string FaxEmpresa { get; set; }
        [Display(Name = "Email")]
        public string EmailEmpresa { get; set; }
        [Display(Name = "Informações Importantes")]
        public string InfoImportantes { get; set; }
        [Display(Name = "Afastamento/Saída")]
        public string AfastamentoSaida { get; set; }
        [Display(Name = "Data da saída")]
        [DataType(DataType.Date)]
        public DateTime DataSaida { get; set; }
        [Required]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public String Password { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
