using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.LSPandIsp
{
    public class GoldCustomer : ICustomer
    {
        private readonly TextLogger _logger;
        private readonly GoldCustomerValidation _validation;

        public GoldCustomer()
        {
            _logger = new TextLogger();
            _validation = new GoldCustomerValidation();
        }

        public void Add(string name)
        {
            try
            {
                _validation.Validate(name);
                Console.WriteLine($"Gold customer name {name} addedd to DB...!!!");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
        }

        public decimal CalculateDiscount(decimal amount)
        {
            return amount - amount * 0.20M;
        }
    }
}
