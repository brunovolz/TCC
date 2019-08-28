﻿using Newtonsoft.Json;
using PadawanProject.Enums;
using PadawanProject.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Modelo : UserControls
    {
        [Key]
        public int Id { get; set; }
        [ValidaLocacao(LocacaoEnum.ValidaModelo)]
        public string Descricao { get; set; }
        public virtual Marca Marca { get; set; }
    }
}