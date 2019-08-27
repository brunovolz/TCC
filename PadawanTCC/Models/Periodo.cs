using System;
using System.ComponentModel.DataAnnotations;

namespace PadawanTCC.Models
{
    public class Periodo : UserControls
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public DateTime InicioLocacao { get; set; }
        public DateTime FimLocacao { get; set; }
        public decimal Preco { get; set; } 
    }
}