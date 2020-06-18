using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    public class Srp
    {
        private static readonly Logger _logger;
        private static readonly Validation _validation;

        static Srp()
        {
            _logger = new Logger();
            _validation = new Validation();
        }

        public static void AddToDb()
        {
            var customer = new Customer(_logger, _validation);
            customer.Add("MockCustomer");
        }

        public static void ThrowExceptionWhileAddToDb()
        {
            var customer = new CustomerSRPViolation();
            customer.Add("");
        }
    }
}
