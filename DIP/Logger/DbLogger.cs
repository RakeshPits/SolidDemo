using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Logger
{
    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message} logged to Db");
        }
    }
}
