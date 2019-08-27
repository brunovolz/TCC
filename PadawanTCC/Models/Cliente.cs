using System.ComponentModel.DataAnnotations;

namespace PadawanTCC.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
    }
}