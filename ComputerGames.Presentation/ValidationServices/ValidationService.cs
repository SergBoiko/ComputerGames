using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerGames.Presentation.ValidationServices
{
    public class ValidationService
    {
        protected void Validate(object obj)
        {
            ICollection<ValidationResult> lstvalidationResult;

            bool valid = GenericValidator.TryValidate(obj, out lstvalidationResult);
            if (!valid)
            {
                foreach (ValidationResult res in lstvalidationResult)
                {
                    throw new ArgumentException(res.MemberNames + ":" + res.ErrorMessage);
                }
            }
        }
    }
}
