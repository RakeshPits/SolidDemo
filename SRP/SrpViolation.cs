using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    public class SrpViolation
    {
        public static void AddToDb()
        {
            var customer = new CustomerSRPViolation();
            customer.Add("MockCustomer");
        }

        public static void ThrowExceptionWhileAddToDb()
        {
            var customer = new CustomerSRPViolation();
            customer.Add("");
        }
    }
}
