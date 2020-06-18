using SolidDemo.DIP.Logger;
using SolidDemo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Customers
{
    public class SilverCustomer : ICustomer
    {
        private readonly ILogger _logger;
        private readonly IValidation _validation;

        public SilverCustomer(ILogger logger, IValidation validation)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _validation = validation ?? throw new ArgumentNullException(nameof(validation));
        }

        public void Add(string name)
        {
            try
            {
                _validation.Validate(name);
                Console.WriteLine($"Silver customer name {name} addedd to DB...!!!");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
        }

        public decimal CalculateDiscount(decimal amount)
        {
            return amount - amount * 0.10M;
        }
    }
}
