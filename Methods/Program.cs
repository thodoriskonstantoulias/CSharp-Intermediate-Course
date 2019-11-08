using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 3 : Methods

            //3.1 : Method overloading, Exception handling
            //try
            //{
            //    var point = new Point(10, 20);
            //    //point.Move(new Point(30, 40));
            //    point.Move(null);
            //    Console.WriteLine("Point is at location ({0}, {1})", point.X, point.Y);

            //    point.Move(100, 200);
            //    Console.WriteLine("2ns point is at location ({0}, {1})", point.X, point.Y);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An error occured!");
            //}

            //---------------------------------------------------------------------------

            //3.2 : Params in functions

            //var calculator = new Calculator();
            //var sumTest = calculator.Add(1,2,3,4,5);
            //Console.WriteLine("The sum is : {0}", sumTest);

            //----------------------------------------------------------

            //3.3 : Try parse and out keyword
            int number;
            //var result = int.TryParse("abc", out number);
            var result = int.TryParse("123", out number);
            if (result)
            {
                Console.WriteLine("Number from TryParse is : {0}", number);
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }

            //---------------------------------------------------------------
        }
    }
}
