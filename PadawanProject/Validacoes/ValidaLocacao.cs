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
                        { return ValidarMarca(value, validationContext.DisplayName); }
                    case LocacaoEnum.ValidaModelo:
                        { return ValidarModelo(value, validationContext.DisplayName); }
                    case LocacaoEnum.ValidaPlaca:
                        { return ValidarPlaca(value); }
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
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var tipo = db.TipoVeiculos.FirstOrDefault(x => x.Id == (int)value); //verificar se já existe no banco
            if (tipo != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            if (tipo == null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarMarca(object value, string displayField)
        {
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var tipo = db.Marcas.FirstOrDefault(x => x.Id == (int)value); //verificar se já existe no banco
            if (tipo != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            if (tipo == null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarModelo(object value, string displayField)
        {
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var tipo = db.Modelos.FirstOrDefault(x => x.Id == (int)value); //verificar se já existe no banco
            if (tipo != null)
                return new ValidationResult($"O campo {displayField} já existe.");

            if (tipo == null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        /// <summary>
        /// Metodo para retornar se é valido ou não
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /*private bool ValidaRegexPlaca (string value)
        {
            var placaBR = Regex.IsMatch(value.ToString(), @"^[A-Z]{3}[0-9]{4}$");
            var placaMerc = Regex.IsMatch(value.ToString(), @"^[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}$");

            if (placaBR.Equals(value)|(placaMerc.Equals(value)))
            {
                return true;
            }
            return false;
        }*/
        private ValidationResult ValidarPlaca(object value)
        {
            if (value == null)
                return new ValidationResult($"A placa é obrigatória!");

            string pattern = @"^[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}$|^[A-Z]{3}[0-9]{4}$";
            bool result = Regex.IsMatch(value.ToString(), pattern);

            if (result)
            {
                var tipo = db.Locacoes.FirstOrDefault(x => x.Placa == value.ToString()); //verificar se já existe no banco
                if (tipo != null)
                    return new ValidationResult($"A placa já está cadastrada no sistema.");
                if (tipo == null)
                    return ValidationResult.Success;
            }

            return new ValidationResult($"O formato de placa é inválido.");
        }
    }
}