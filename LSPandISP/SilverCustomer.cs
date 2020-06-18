using System;
using System.Collections.Generic;
using System.Text;
using SolidDemo.SRP;

namespace SolidDemo.LSPandIsp
{
    public class SilverCustomer : ICustomer
    {
        private readonly TextLogger _logger;
        private readonly SilverCustomerValidation _validation;

        public SilverCustomer()
        {
            _logger = new TextLogger();
            _validation = new SilverCustomerValidation();
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
