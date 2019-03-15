using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrizm.Validation
{
    class Validation
    {

        public List<ValidationResult> Valid(object validate)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(validate);
            Validator.TryValidateObject(validate, context, results, true);
            return results;
        }

    }
}
        
                

