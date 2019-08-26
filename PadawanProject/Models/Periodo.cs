using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Periodo
    {
        [Key]
        public int Id { get; set; }
        public DateTime InicioLocacao { get; set; }
        public DateTime FimLocacao { get; set; }
        public float Valor { get; set; } = 0;
        [JsonIgnore]
        public virtual ICollection<Periodo> PeriodoFK { get; set; }
    }
}