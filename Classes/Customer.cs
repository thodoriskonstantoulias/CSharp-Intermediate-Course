using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //Lessons 
    //- Overloading constructors
    //- this() : is a keyword that transfers the control to the appropriate constructor so code is not repeated 
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id,string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }

    }
}
