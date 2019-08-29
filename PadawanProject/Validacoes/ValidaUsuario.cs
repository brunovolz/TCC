using PadawanProject.Enums;
using PadawanProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PadawanProject.Validacoes
{
    public class ValidaUsuario : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private UsuarioEnum validarUsuario;

        public ValidaUsuario(UsuarioEnum type)
        {
            validarUsuario = type;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (validarUsuario)
                {
                    case UsuarioEnum.ValidaNome:
                        { return ValidarNome(value); }
                    case UsuarioEnum.ValidaMatricula:
                        { return ValidarMatricula(value, validationContext.DisplayName); }
                    case UsuarioEnum.ValidaEmail:
                        { return ValidarEmail(value); }
                    case UsuarioEnum.ValidaDataNasc:
                        //{ return ValidarDataNasc(value, validationContext.DisplayName); }
                    case UsuarioEnum.ValidaPcd:
                        break;
                    case UsuarioEnum.ValidaCidade:
                        break;
                    case UsuarioEnum.ValidaNoturno:
                        break;
                    case UsuarioEnum.ValidaCarona:
                        break;
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
        }
        private ValidationResult ValidarNome(object value)
        {
            if (value == null)
                return new ValidationResult($"O Nome é obrigatório!");
            return ValidationResult.Success;
        }
        private ValidationResult ValidarEmail(object value)
        {
            if (value == null)
                return new ValidationResult($"O campo E-mail é obrigatório!");

            string pattern = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";
            bool result = Regex.IsMatch(value.ToString(), pattern);

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"EMAIL inválido!");
        }
        private ValidationResult ValidarMatricula(object value, string displayField)
        {
            if (value == null)
                return new ValidationResult($"O campo {displayField} é obrigatório!");

            var matricula = db.Usuarios.FirstOrDefault(x => x.Matricula.ToString() == (string)value);
            if (matricula != null)
                return ValidationResult.Success;
            
            if (matricula == null)
                return new ValidationResult($"Matrícula não está registrada!");

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        public static int PegarIdade(DateTime AnoAniversario)
        {
            DateTime dateTime = DateTime.Now;
            int idade = dateTime.Year - AnoAniversario.Year;

            if (dateTime.Month < AnoAniversario.Month || (dateTime.Month == AnoAniversario.Month && dateTime.Day < AnoAniversario.Day))
                idade--;
            return idade;
        }
    }
}