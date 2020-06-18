using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.SRP
{
    public class Logger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"Exception {message} logged to File...!!!");
        }
    }
}
