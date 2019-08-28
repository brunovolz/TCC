using PadawanProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace PadawanProject.Validacoes
{
    public class CustomValidation : ValidationAttribute
    {
        ContextDB db = new ContextDB();
        public string OtherProperty { get; set; }

        public string tipoCampo { get; set; }

        public CustomValidation(string pTipoCampo)
        {
            tipoCampo = pTipoCampo;
        }
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //  switch(tipoCampo)
        //}      
    }
}