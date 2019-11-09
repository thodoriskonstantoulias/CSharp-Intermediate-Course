using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Car : Vehicle
    {
        //First parent parameterless constructor is executed and then the child
        //unless we specify with the base keyword which parent contructor must be executed
        public Car()
        {
            Console.WriteLine("Car is initialized");
        }

        public Car(string carNum) : base(carNum)
        {
            Console.WriteLine("Car number is {0}", carNum);
        }
    }
}
