using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoLib
{
    public class Stack<T>
    {
        List<T> elements = new List<T>();

        // Adds a data element to the top of the stack
        // Just simply add the element to the List.
        public void Push(T element)
        {
            elements.Add(element);
        }

        // Removes a data element from the top of the stack.
        // Throw InvalidOperationException if the stack is empty.
        public T Pop()
        {
            if (Size <= 0)
                throw new InvalidOperationException("Empty Stack");

            T retEle = elements.Last();
            elements.RemoveAt(Size - 1);
            return retEle;
        }

        // Returns the total number of elements in the stack.
        public int Size
        {
            get { return elements.Count; }
        }

        // Returns true if the stack is empty.
        public bool isEmpty()
        {
            return Size <= 0;
        }

    }

}
