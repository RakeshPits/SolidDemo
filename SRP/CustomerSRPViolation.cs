using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    class CustomerSRPViolation
    {
        public void Add(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException();
                }

                Console.WriteLine($"customer name {name} addedd to DB...!!!");                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.Message} logged to File...!!!");
            }
        }
    }
}
