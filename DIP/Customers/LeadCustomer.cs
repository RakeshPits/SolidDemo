using SolidDemo.DIP.Logger;
using SolidDemo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Customers
{
    public class LeadCustomer : ILead
    {
        private readonly ILogger _logger;
        private readonly IValidation _validation;
       
        public LeadCustomer(ILogger logger, IValidation validation)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _validation = validation ?? throw new ArgumentNullException(nameof(validation));
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
