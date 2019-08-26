using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int TipoVeiculo { get; set; }
        public int Marca { get; set; }
        public int Modelo { get; set; }
        public int Cor { get; set; }
        public string PlacaVeiculo { get; set; }
        public int Periodo { get; set; }
        public int Usuario { get; set; }
        public int TermoDeUso { get; set; }
        public int Status { get; set; }
        [JsonIgnore]
        [ForeignKey("Cliente")]
        public virtual Cliente ClienteFK { get; set; }
        [JsonIgnore]
        [ForeignKey("TipoVeiculo")]
        public virtual TipoVeiculo TipoVeiculoFK { get; set; }
        [JsonIgnore]
        [ForeignKey("Marca")]
        public virtual Marca MarcaFK { get; set; }
        [JsonIgnore]
        [ForeignKey("Modelo")]
        public virtual Modelo ModeloFK { get; set; }
        [JsonIgnore]
        [ForeignKey("Cor")]
        public virtual Cor CorFK { get; set; }
        [JsonIgnore]
        [ForeignKey("Periodo")]
        public virtual Periodo PeriodoFK { get; set; }
        [JsonIgnore]
        [ForeignKey("Usuario")]
        public virtual Usuario UsuarioFK { get; set; }
        [JsonIgnore]
        [ForeignKey("TermoDeUso")]
        public virtual TermoUso TermoFK { get; set; }
    }
}