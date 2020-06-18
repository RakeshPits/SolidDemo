using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.LSPandIsp
{
    class LeadCustomer : ILead
    {
        private readonly TextLogger _logger;
        private readonly LeadCustomerValidation _validation;

        public LeadCustomer()
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
    }
}
