using Newtonsoft.Json;
using PadawanProject.Enums;
using PadawanProject.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Locacao : UserControls
    {
        [Key]
        public int Id { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaTipoVeiculo)]
        public int TipoVeiculoId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaPlaca)]
        public string Placa { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaMarca)]
        public int? MarcaId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaCor)]
        public int? CorId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaPeriodo)]
        public int PeriodoId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaUsuario)]
        public int UsuarioId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaTermo)]
        public bool AceitarTermoUso { get; set; }
        public int TermoUsoId { get; set; }
        public int? StatusLocacaoFK { get; set; }
        [ForeignKey("TermoUsoId")]
        public virtual TermoUso TermoUso { get; set; }
        [ForeignKey("PeriodoId")]
        public virtual Periodo Periodo { get; set; }
        [ForeignKey("CorId")]
        public virtual Cor Cor { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }
    }
}