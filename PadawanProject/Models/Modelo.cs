using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        public int Marca { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Marca> MarcaFK { get; set; }
        public virtual ICollection<Modelo> ModeloFK { get; set; }
    }
}