using SolidDemo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Validation
{
    public class SilverCustomerValidation : IValidation
    {
        public void Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
