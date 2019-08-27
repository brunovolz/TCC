using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadawanTCC.Models
{
    public class Usuario : UserControls
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Pcd { get; set; }
        public bool Cidade { get; set; }
        public bool Noturno { get; set; }
        public bool Carona { get; set; }
    }
}