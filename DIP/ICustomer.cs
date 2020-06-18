using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP
{
     public interface ICustomer : ILead
    {
        decimal CalculateDiscount(decimal amount);
    }
}
