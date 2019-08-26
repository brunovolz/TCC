﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        [JsonIgnore]
        public virtual ICollection<Cliente> ClienteFK { get; set; }
    }
}