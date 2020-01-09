using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        private readonly List<Object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(Object obj) 
        {
            if (obj != null)
            {
                _stack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Push null object exception");
            }
        }

        public Object Pop() 
        {
            Object toReturn = new Object();

            if (_stack.Count > 0)
            {
                toReturn = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1); 
            }
            else
            {
                throw new InvalidOperationException("Pop on empty list exception");
            }

            return toReturn;
        }

        public void Clear() 
        {
            if (_stack.Count > 0)
            {
                _stack.Clear();
            }
        }

    }
}
