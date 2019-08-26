using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Cor
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Cor> CorFK { get; set; }
    }
}