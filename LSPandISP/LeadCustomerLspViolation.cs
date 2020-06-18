using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.LSPandIsp
{
    class LeadCustomerLspViolation : ICustomer
    {
        private readonly TextLogger _logger;
        private readonly LeadCustomerValidation _validation;

        public LeadCustomerLspViolation()
        {
            _logger = new TextLogger();
            _validation = new LeadCustomerValidation();
        }

        public void Add(string name)
        {
            try
            {
                _validation.Validate(name);
                Console.WriteLine($"Lead customer name {name} addedd to DB...!!!");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
        }

        public decimal CalculateDiscount(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
