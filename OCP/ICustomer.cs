using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.Ocp
{
    public interface ICustomer
    {
        void Add(string name);
        decimal CalculateDiscount(decimal amount);
    }
}
