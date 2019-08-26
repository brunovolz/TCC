﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Pcd { get; set; }
        public bool Cidade { get; set; }
        public bool Noturno { get; set; }
        public bool Carona { get; set; }
        [JsonIgnore]
        public virtual ICollection<Usuario> UsuarioFK { get; set; }

        private ICollection<Usuario> usuCriacaoFK;

        public virtual ICollection<Usuario> GetUsuCriacaoFK()
        {
            return usuCriacaoFK;
        }

        public virtual void SetUsuCriacaoFK(ICollection<Usuario> value)
        {
            usuCriacaoFK = value;
        }

        private ICollection<Usuario> usuAlteracaFK;

        public virtual ICollection<Usuario> GetUsuAlteracaFK()
        {
            return usuAlteracaFK;
        }

        public virtual void SetUsuAlteracaFK(ICollection<Usuario> value)
        {
            usuAlteracaFK = value;
        }
    }
}