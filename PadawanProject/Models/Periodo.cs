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
        [Display(Name = "Data de Inicio do Periodo de Locação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime InicioLocacao { get; set; }
        [Display(Name = "Data Final do Periodo de Locação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime FimLocacao { get; set; }
        public decimal Valor { get; set; } = 0;
        public int Quantidade { get; set; }
        public int TipoVeiculoPeriodoFK { get; set; }
        [ForeignKey("TipoVeiculoPeriodoFK")]
        public virtual TipoVeiculo TipoVeiculo { get; set; }
    }
}