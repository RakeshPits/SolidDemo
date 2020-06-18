using SolidDemo.DIP.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Factory
{
    public class CustomerFactory
    {
        private readonly IDictionary<CustomerType, ICustomer> _customerDictionary = new Dictionary<CustomerType, ICustomer>();

        public CustomerFactory()
        {
            _customerDictionary.Add(CustomerType.GOLD, new GoldCustomer(new LogFactory().GetLogger(LogType.TEXT),
                                                       new ValidationFactory().GetValidator(CustomerType.GOLD)));
            _customerDictionary.Add(CustomerType.SILVER, new SilverCustomer(new LogFactory().GetLogger(LogType.TEXT),
                                                      new ValidationFactory().GetValidator(CustomerType.SILVER)));
        }

        public ICustomer GetCustomer(CustomerType customerType)
        {
            return _customerDictionary[customerType];
        }
    }
}
