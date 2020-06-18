using SolidDemo.DIP.Validation;
using SolidDemo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Factory
{
    public class ValidationFactory
    {
        private readonly IDictionary<CustomerType, IValidation> _validationDictionary = new Dictionary<CustomerType, IValidation>();

        public ValidationFactory()
        {
            _validationDictionary.Add(CustomerType.GOLD, new GoldCustomerValidation());
            _validationDictionary.Add(CustomerType.SILVER, new SilverCustomerValidation());
        }

        public IValidation GetValidator(CustomerType customerType)
        {
            return _validationDictionary[customerType];
        }
    }
}
