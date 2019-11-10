using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Shape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
}
