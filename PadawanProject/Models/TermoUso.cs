﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class TermoUso
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<TermoUso> TermoFK { get; set; }
    }
}