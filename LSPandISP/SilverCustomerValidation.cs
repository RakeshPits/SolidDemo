﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.LSPandIsp
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