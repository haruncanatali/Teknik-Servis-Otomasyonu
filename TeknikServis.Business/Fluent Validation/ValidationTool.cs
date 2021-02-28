using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis.Business.Fluent_Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,Object obje)
        {
            var result = validator.Validate(obje);
            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
