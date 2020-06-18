using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
using SolidDemo.DIP.Logger;
using SolidDemo.Validation;
using SolidDemo.DIP.Validation;
using SolidDemo.DIP.Customers;

namespace SolidDemo.DIP.Ninject
{
    public class Di : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<TextLogger>().Named("Text");
            Bind<ILogger>().To<DbLogger>().Named("Db");
            Bind<IValidation>().To<GoldCustomerValidation>().Named("Gold");
            Bind<IValidation>().To<SilverCustomerValidation>().Named("Silver");           
            Bind<ICustomer>().ToConstructor(c => new GoldCustomer(c.Context.Kernel.Get<ILogger>("Text"), c.Context.Kernel.Get<IValidation>("Gold"))).Named("Gold");            
            Bind<ICustomer>().ToConstructor(c => new SilverCustomer(c.Context.Kernel.Get<ILogger>("Text"), c.Context.Kernel.Get<IValidation>("Silver"))).Named("Silver");
        }
    }
}
