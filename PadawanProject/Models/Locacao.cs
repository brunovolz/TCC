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
        public virtual Cliente Cliente { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaPlaca)]
        public string Placa { get; set; }
        //[ValidaLocacao(LocacaoEnum.ValidaMarca)]
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Cor Cor { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Usuario Usuario{ get; set; }
        public virtual TermoUso Termo { get; set; }
        public virtual StatusLocacao StatusLocacao { get; set; }
    }
}