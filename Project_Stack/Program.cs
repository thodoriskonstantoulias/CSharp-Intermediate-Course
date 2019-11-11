﻿using System;

namespace Project_Stack
{
    //A Stack is a data structure for storing a list of elements in a LIFO(last in, first out) fashion.
    //Design a class called Stack with three methods.
    //void Push(object obj)
    //object Pop()
    //void Clear()
    //The Push() method stores the given object on top of the stack. We use the “object” type here so
    //we can store any objects inside the stack.Remember the “object” class is the base of all classes
    //in the.NET Framework.So any types can be automatically upcast to the object. Make sure to
    //take into account the scenario that null is passed to this object. We should not store null
    //references in the stack. So if null is passed to this method, you should throw an
    //InvalidOperationException.
    //The Pop() method removes the object on top of the stack and returns it.Make sure to take into
    //account the scenario that we call the Pop() method on an empty stack. In this case, this method
    //should throw an InvalidOperationException
    //The Clear() method removes all objects from the stack.

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
