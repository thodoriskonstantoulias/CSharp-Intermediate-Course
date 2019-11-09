using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message from Logger is : {0}", message);
        }
    }
}
