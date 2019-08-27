using System.ComponentModel.DataAnnotations;

namespace PadawanTCC.Models
{
    public class Modelo : UserControls
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Marca { get; set; }
        public string Descricao { get; set; }
    }
}