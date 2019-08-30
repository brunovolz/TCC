using Newtonsoft.Json;
using PadawanProject.Validacoes;
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
        [ValidaUsuario(Enums.UsuarioEnum.ValidaNome)]
        public string Nome { get; set; }
        [ValidaUsuario(Enums.UsuarioEnum.ValidaMatricula)]
        public string Matricula { get; set; }
        [ValidaUsuario(Enums.UsuarioEnum.ValidaEmail)]
        public string Email { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime DataNasc { get; set; }
        public bool Pcd { get; set; }
        public bool Cidade { get; set; }
        public bool Noturno { get; set; }
        public bool Carona { get; set; }
    }
}