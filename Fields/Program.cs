using Classes;
using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 4 : Fields

            //Use of readonly field to initialize list only once(in Classes project --> Customer class)
            //var customer = new Customer();
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //customer.Promote();
            //Console.WriteLine(customer.Orders.Count);

            //Lesson 5 : Access modifiers

            var person = new Person();
            person.SetBirthdate(new DateTime(2019, 11, 09));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
