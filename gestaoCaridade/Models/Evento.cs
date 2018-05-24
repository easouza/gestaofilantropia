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

        #region Equipe

        [ForeignKey("ResponsavelMesa")]
        [Display(Name = "Responsavel Mesa")]
        public int idResponsavelMesa { get; set; }
        [ForeignKey("ResponsavelPalco")]
        [Display(Name = "Responsavel Palco")]
        public int idResponsavelPalco { get; set; }
        [ForeignKey("ResponsavelCozinha")]
        [Display(Name = "Responsavel Cozinha")]
        public int idResponsavelCozinha { get; set; }
        [ForeignKey("ResponsavelBebidas")]
        [Display(Name = "Responsavel Bebidas")]
        public int idResponsavelBebidas { get; set; }
        [ForeignKey("ResponsavelCaixas")]
        [Display(Name = "Responsavel Caixas")]
        public int idResponsavelCaixas { get; set; }
        [ForeignKey("ResponsavelLixo")]
        [Display(Name = "Responsavel Lixo")]
        public int idResponsavelLixo { get; set; }
        [ForeignKey("ResponsavelSeguranca")]
        [Display(Name = "Responsavel Seguranca")]
        public int idResponsavelSeguranca { get; set; }
        [ForeignKey("ResponsavelLimpeza")]
        [Display(Name = "Responsavel Limpeza")]
        public int idResponsavelLimpeza { get; set; }

        [Display(Name = "Responsavel Mesa")]
        public virtual Membro ResponsavelMesa { get; set; }
        [Display(Name = "Responsavel Palco")]
        public virtual Membro ResponsavelPalco { get; set; }
        [Display(Name = "Responsavel Cozinha")]
        public virtual Membro ResponsavelCozinha { get; set; }
        [Display(Name = "Responsavel Bebidas")]
        public virtual Membro ResponsavelBebidas { get; set; }
        [Display(Name = "Responsavel Caixas")]
        public virtual Membro ResponsavelCaixas { get; set; }
        [Display(Name = "Responsavel Lixo")]
        public virtual Membro ResponsavelLixo { get; set; }
        [Display(Name = "Responsavel Seguranca")]
        public virtual Membro ResponsavelSeguranca { get; set; }
        [Display(Name = "Responsavel Limpeza")]
        public virtual Membro ResponsavelLimpeza { get; set; }

        #endregion

        #region Checklist

        [Display(Name = "Clube Agendado")]
        public bool ClubeAgendado { get; set; }
        [Display(Name = "Numero de Mesas Confirmadas")]
        public bool ConfirmarNumeroMesas { get; set; }
        [Display(Name = "Cozinha Verificada")]
        public bool VerificaCozinha { get; set; }
        [Display(Name = "Confirmar quantos funcionarios poderao trabalhar")]
        public bool ConfirmarFuncionarios { get; set; }
        [Display(Name = "Confeccionar convites")]
        public bool ConfeccionarConvites { get; set; }
        [Display(Name = "Fazer carta de pedido de brindes")]
        public bool FazerCartaPedidos { get; set; }
        [Display(Name = "Entregar Convites")]
        public bool EntregarConvites { get; set; }
        [Display(Name = "Fazer carta de agradecimento")]
        public bool FazerCartaAgradecimento { get; set; }
        [Display(Name = "Fazer carta solicitanto ajuda de Betheis e Demolays")]
        public bool FazerCartaBetheisDemolays { get; set; }
        [Display(Name = "Comprar cartelas")]
        public bool ComprarCartela { get; set; }
        [Display(Name = "Numerar cartelas")]
        public bool NumerarCartela { get; set; }
        [Display(Name = "Carimbar cartelas")]
        public bool CarimbarCartela { get; set; }
        [Display(Name = "Contratar som (caso o clube tiver)")]
        public bool ContratarSom { get; set; }
        [Display(Name = "Contratar segurancas")]
        public bool ContratarSegurancas { get; set; }
        [Display(Name = "Provindeciar roleta para o bingo")]
        public bool ProvidenciarRoleta { get; set; }
        [Display(Name = "Separar fichas")]
        public bool SepararFichas { get; set; }
        [Display(Name = "Levar troco")]
        public bool LevarTroco { get; set; }
        [Display(Name = "Providenciar caixas de dinheiro")]
        public bool ProvidenciarCaixaDinheiro { get; set; }
        [Display(Name = "Providenciar vasilha para venda de doces")]
        public bool ProvidenciarVasilha { get; set; }
        [Display(Name = "Providenciar pratinhos, colheres e garfos")]
        public bool ProvidenciarPratinhos { get; set; }
        [Display(Name = "Providenciar pratos e garfos para tropeiro")]
        public bool ProvidenciarPratosGarfos { get; set; }
        [Display(Name = "Providenciar copos e colheres para caldos")]
        public bool ProvidenciarCoposColheres { get; set; }
        [Display(Name = "Providenciar lapis")]
        public bool ProvidenciarLapis { get; set; }
        [Display(Name = "Providenciar guardanapos")]
        public bool ProvidenciarGuardanapos { get; set; }
        [Display(Name = "Providenciar pano de prato")]
        public bool ProvidenciarPanodePrato { get; set; }
        [Display(Name = "Providenciar perfex")]
        public bool ProvidenciarPerfex { get; set; }
        [Display(Name = "Providenciar fosforo")]
        public bool ProvidenciarFosforo { get; set; }
        [Display(Name = "Providenciar buchinha")]
        public bool ProvidenciarBuchinha { get; set; }
        [Display(Name = "Providenciar papel higienico")]
        public bool ProvidenciarPapelHigienico { get; set; }
        [Display(Name = "Providenciar toalha de mesa")]
        public bool ProvidenciarToalhaMesa { get; set; }
        [Display(Name = "Providenciar saco de lixo")]
        public bool ProvidenciarSacoLixo { get; set; }
        [Display(Name = "Providenciar cesta para carregar bebidas")]
        public bool ProvidenciarCestaBebida { get; set; }
        [Display(Name = "Providenciar bandejas")]
        public bool ProvidenciarBandejas { get; set; }
        [Display(Name = "Providenciar crachas para quem ira trabalhar")]
        public bool ProvidenciarCrachas { get; set; }
        [Display(Name = "Providenciar bloco de rascunho")]
        public bool ProvidenciarBloquinho { get; set; }
        [Display(Name = "Providenciar bebidas")]
        public bool ProvidenciarBebidas { get; set; }
        [Display(Name = "Providenciar comidas")]
        public bool ProvidenciarComidas { get; set; }
        [Display(Name = "FAzer cardapio com precos e imprimir")]
        public bool FazerCardapio { get; set; }
        [Display(Name = "Fazer agradcimento aos doadores")]
        public bool FazerAgradecimento { get; set; }
        [Display(Name = "Fazer lista com os brindes doados")]
        public bool FazerListaBrindes { get; set; }
        [Display(Name = "Comprar plastico para embalar as prendas")]
        public bool ComparPlasticoEmbalar { get; set; }
        [Display(Name = "Fazer vale ticket para Demolays e filhas de Jo")]
        public bool FazerValeTicket { get; set; }
        [Display(Name = "Fazer escala das funcoes")]
        public bool FazerEscala { get; set; }
        [Display(Name = "Marcar horario chegada")]
        public bool MarcarHorarioChegada { get; set; }



        #endregion
    }
}
