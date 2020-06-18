using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.DIP.Logger
{
    public class TextLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message} logged to Tex");
        }
    }
}
