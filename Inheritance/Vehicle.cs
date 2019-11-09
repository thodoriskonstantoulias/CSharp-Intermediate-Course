using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Vehicle
    {
        private readonly string _regNum;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is initialized");
        }
        public Vehicle(string regNum)
        {
            this._regNum = regNum;
            Console.WriteLine("Vehicle number is {0}", _regNum);
        }
    }
}
