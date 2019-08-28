using PadawanProject.Enums;
using PadawanProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Web;

namespace PadawanProject.Validacoes
{
    public class ValidaLocacao : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private LocacaoEnum validarLocacao;

        public ValidaLocacao(LocacaoEnum type)
        {
            validarLocacao = type;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (validarLocacao)
                {
                    case LocacaoEnum.ValidaTipoVeiculo:
                        { return ValidarTVeiculo(value, validationContext.DisplayName); }
                    case LocacaoEnum.ValidaMarca:
                        break;
                    case LocacaoEnum.ValidaModelo:
                        break;
                    case LocacaoEnum.ValidaCor:
                        break;
                    case LocacaoEnum.ValidaPeriodo:
                        break;
                    case LocacaoEnum.ValidaUsuario:
                        break;
                    case LocacaoEnum.ValidaTermo:
                        break;
                    case LocacaoEnum.ValidaStatusLocacao:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
        }
        private ValidationResult ValidarTVeiculo(object value, string displayField)
        {
            var tipo = db.TipoVeiculos.FirstOrDefault(x => x.Descricao == value.ToString()); //verificar se já existe no banco
            if (tipo != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
    }
}