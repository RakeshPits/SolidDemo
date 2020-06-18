using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemo.LSPandIsp
{
    public class TextLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message} logged to Tex");
        }
    }
}
