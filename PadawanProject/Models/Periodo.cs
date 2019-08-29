using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Periodo : UserControls
    {
        [Key]
        public int Id { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime InicioLocacao { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime FimLocacao { get; set; } 
        public decimal Valor { get; set; } = 0;
        public int Quantidade { get; set; }
        public int TipoVeiculoPeriodoFK { get; set; }
        [ForeignKey("TipoVeiculoPeriodoFK")]
        public virtual TipoVeiculo TipoVeiculo { get; set; }
    }
}