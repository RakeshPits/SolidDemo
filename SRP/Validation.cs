using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    public class Validation
    {
        public void Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
