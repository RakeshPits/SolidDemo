﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.Ocp
{
    public class SilverCustomerValidation
    {
        public void Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
