using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPadawanProject.Models
{
    public class Veiculo
    {
        [Key]
        public string Automovel { get; set; }
        public string Motocicleta { get; set; }
        public string Bicicleta { get; set; }
        public string Patinete { get; set; }
    }
}