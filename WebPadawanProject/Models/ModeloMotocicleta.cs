﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPadawanProject.Models
{
    public class ModeloMotocicleta
    {
        [Key]
        [ForeignKey("Id")]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
    }
}