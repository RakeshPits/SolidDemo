using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    public class Customer
    {
        private readonly Logger _logger;
        private readonly Validation _validation;
       
        public Customer(Logger logger, Validation validation)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _validation = validation ?? throw new ArgumentNullException(nameof(validation));
        }

        public void Add(string name)
        {
            try
            {
                _validation.Validate(name);
                Console.WriteLine($"customer name {name} addedd to DB...!!!");
            }
            catch (Exception ex)
            {
                _logger.WriteLog(ex.Message);
            }
        }
    }
}
