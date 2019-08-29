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
        public int TipoVeiculoId { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaPlaca)]
        public string Placa { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaMarca)]
        public int? MarcaId { get; set; }
        //public int? ModeloId { get; set; }
        public int? CorId { get; set; }
        public int PeriodoId { get; set; }
        public int UsuarioId { get; set; }
        public int TermoId { get; set; }
        public int? StatusLocacaoFK { get; set; }
        [ForeignKey("StatusLocacaoFK")]
        public virtual StatusLocacao StatusLocacao { get; set; }
        [ForeignKey("TermoId")]
        public virtual TermoUso Termo { get; set; }
        [ForeignKey("PeriodoId")]
        public virtual Periodo Periodo { get; set; }
        [ForeignKey("CorId")]
        public virtual Cor Cor { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        //[ForeignKey("ModeloId")]
        //public virtual Modelo Modelo { get; set; }
        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }
        //[ForeignKey("TipoVeiculoId")]
        //public virtual TipoVeiculo TipoVeiculo { get; set; }
    }
}