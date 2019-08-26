using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Marca
    {
        [Key]
        public int Id{ get; set; }
        public string Descricao { get; set; }
        public int TipoVeiculo { get; set; }
        public virtual ICollection<TipoVeiculo> TipoVeiculoFK { get; set; }
        public virtual ICollection<Marca> MarcaFK { get; set; }
    }
}