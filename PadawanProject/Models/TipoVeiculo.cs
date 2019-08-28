using Newtonsoft.Json;
using PadawanProject.Enums;
using PadawanProject.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class TipoVeiculo : UserControls
    {
        [Key]
        public int Id { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaTipoVeiculo)]
        public string Descricao { get; set; }
    }
}