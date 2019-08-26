using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class TipoVeiculo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        [JsonIgnore]
        public virtual ICollection<TipoVeiculo> TipoVeiculoFK { get; set; }
    }
}