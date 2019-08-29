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
                        { return ValidarPlaca(value, validationContext); }
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
            if (tipo == null)
                return new ValidationResult($"Veículo inválido!");

            if (tipo != null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarMarca(object value, string displayField)
        {
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var tipo = db.Marcas.FirstOrDefault(x => x.Id == (int)value); //verificar se já existe no banco
            if (tipo == null)
                return new ValidationResult($"Esta marca não consta no banco de dados!");

            if (tipo != null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarModelo(object value, string displayField)
        {
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var tipo = db.Modelos.FirstOrDefault(x => x.Id == (int)value); //verificar se já existe no banco
            if (tipo == null)
                return new ValidationResult($"Modelo inválido");

            if (tipo != null)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarPlaca(object value, ValidationContext validationContext)
        {
            Locacao veiculo = (Locacao)validationContext.ObjectInstance;

            if (veiculo.TipoVeiculoId > 2 && value == null)
                return ValidationResult.Success;
            if (veiculo.TipoVeiculoId > 2 && value != null)
                return new ValidationResult("Esse tipo de veículo não permite o cadastro de placa");
            if (veiculo.TipoVeiculoId == 1 && value != null)
            {
                if (Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$") || Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$"))
                {
                    if (db.Locacoes.Any(x => x.Placa == value.ToString()))
                        return new ValidationResult($"A placa '{value}' já possui um cadastro em nosso sistema");
                    return ValidationResult.Success;
                }
                return new ValidationResult($"Formato inválido no campo {validationContext.DisplayName}");
            }
            if (veiculo.TipoVeiculoId == 2 && value != null)
            {
                if (Regex.IsMatch(value.ToString(), @"^[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}$"))
                {
                    if (!db.Locacoes.Any(x => x.Placa == value.ToString()))
                        return ValidationResult.Success;
                    return new ValidationResult($"A placa '{value}' já está cadastrada em nosso sistema");
                }
                return new ValidationResult($"A placa '{value.ToString()}' não está no formato aceitável");
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} deve ser informado");
        }
    }
}