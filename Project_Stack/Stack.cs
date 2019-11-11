using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Stack
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You must pass a non nullable object");
            }
            _list.Add(obj);

        }
        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var last = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return last;
        }   
        public void Clear()
        {
            _list.Clear();
        }
    }
}
