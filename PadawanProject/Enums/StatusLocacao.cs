using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PadawanProject.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusLocacao
    {
        [EnumMember(Value = "Vigente")]
        Vigente = 1,

        [EnumMember(Value = "Em Aprovação")]
        EmAprovacao = 2,

        [EnumMember(Value = "Fila de Espera")]
        FilaDeEspera = 3
    }
}