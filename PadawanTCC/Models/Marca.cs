﻿using System.ComponentModel.DataAnnotations;

namespace PadawanTCC.Models
{
    public class Marca :UserControls
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int TipoVeiculo { get; set; }
    }
}