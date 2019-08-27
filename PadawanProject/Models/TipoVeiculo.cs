using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class TipoVeiculo : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        
    }
}