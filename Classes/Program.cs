using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1 : Introduction to classes

            // 1st way of creating an instance of a class
            //var person = new Person();
            //person.Name = "Ted";

            // 2nd way of creating an instance of a class (with static)
            var person = Person.Parse("Ted");
            person.Introduce("Mike");
            //-------------------------------------------------------------
            
        }
    }
}
