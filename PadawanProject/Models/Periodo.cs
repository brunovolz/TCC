﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Periodo : UserControls
    {
        [Key]
        public int Id { get; set; }
        public DateTime InicioLocacao { get; set; }
        public DateTime FimLocacao { get; set; }
        public decimal Valor { get; set; } = 0;
        public int Quantidade { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }

    }
}