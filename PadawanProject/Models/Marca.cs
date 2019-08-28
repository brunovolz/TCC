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
    public class Marca : UserControls
    {
        [Key]

        public int Id{ get; set; }
        //[ValidaLocacao(LocacaoEnum.ValidaMarca)]
        public string Descricao { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaMarca)]
        public int TipoVeiculoMarcaFK { get; set; }

        [ForeignKey("TipoVeiculoMarcaFK")]
        public virtual TipoVeiculo TipoVeiculo{ get; set; }
    }
}