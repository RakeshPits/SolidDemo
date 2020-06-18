using SolidDemo.DIP.Factory;
using SolidDemo.LSPandIsp;
using SolidDemo.SRP;
using System;
using System.Collections.Generic;
using Ninject;
using System.Reflection;

namespace SolidDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRPViolation           
            //SrpViolation.AddToDb();
            //SrpViolation.ThrowExceptionWhileAddToDb();
            #endregion

            #region SRPImpliemenation
            //Srp.AddToDb();
            //Srp.ThrowExceptionWhileAddToDb();
            #endregion

            #region OcpImpliementation
            //var price = 100;
            //var customers = new List<ICustomer>()
            //{
            //    new GoldCustomer(),
            //    new SilverCustomer()
            //};

            //var counter = 1;
            //foreach (var customer in customers)
            //{
            //    var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
            //    customer.Add(customerName);
            //    var discount = customer.CalculateDiscount(price);
            //    Console.WriteLine($"Actual price: {price}; discount Price : {discount}");
            //}
            #endregion

            #region LspViolation
            //var price = 100;
            //var customers = new List<ICustomer>()
            //{
            //    new GoldCustomer(),
            //    new SilverCustomer(),
            //    new LeadCustomerLspViolation()
            //};

            //var counter = 1;
            //foreach (var customer in customers)
            //{
            //    var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
            //    customer.Add(customerName);
            //    var discount = customer.CalculateDiscount(price);
            //    Console.WriteLine($"Actual price: {price}; discount Price : {discount}");
            //}
            #endregion

            #region LspImplementatonThroughISP

            //var price = 100;
            //var customers = new List<ICustomer>()
            //{
            //    new GoldCustomer(),
            //    new SilverCustomer()
            //};

            //var counter = 1;
            //foreach (var customer in customers)
            //{
            //    var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
            //    customer.Add(customerName);
            //    var discount = customer.CalculateDiscount(price);
            //    Console.WriteLine($"Actual price: {price}; discount Price : {discount}");
            //}

            //var leadCustomers = new List<ILead>()
            //{
            //    new GoldCustomer(),
            //    new SilverCustomer(),
            //    new LeadCustomer()
            //};

            //foreach (var customer in leadCustomers)
            //{
            //    var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
            //    customer.Add(customerName);     
            //}
            #endregion

            #region DIPImplementation
            //var customerFactory = new CustomerFactory();            
            //var customers = new List<SolidDemo.DIP.ICustomer>()
            //{
            //    customerFactory.GetCustomer(CustomerType.GOLD),
            //    customerFactory.GetCustomer(CustomerType.SILVER)
            //};

            //var price = 100;
            //var counter = 1;
            //foreach (var customer in customers)
            //{
            //    var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
            //    customer.Add(customerName);
            //    var discount = customer.CalculateDiscount(price);
            //    Console.WriteLine($"Actual price: {price}; discount Price : {discount}");
            //}

            #endregion

            #region Ninject
            var kernal = new StandardKernel();
            kernal.Load(Assembly.GetExecutingAssembly());
            var customers = kernal.GetAll<SolidDemo.DIP.ICustomer>();
            var price = 100;
            var counter = 1;
            foreach (var customer in customers)
            {
                var customerName = customer is GoldCustomer ? $"GoldCustomer{counter++}" : $"SilverCustomer{counter++}";
                customer.Add(customerName);
                var discount = customer.CalculateDiscount(price);
                Console.WriteLine($"Actual price: {price}; discount Price : {discount}");
            }

            // resove paricular customer from Ninject
            var goldCustomer = kernal.Get<SolidDemo.DIP.ICustomer>("Gold");
            var goldDiscount = goldCustomer.CalculateDiscount(price);
            Console.WriteLine($"Actual price: {price}; discount Price : {goldDiscount}");
            #endregion
        }
    }
}
