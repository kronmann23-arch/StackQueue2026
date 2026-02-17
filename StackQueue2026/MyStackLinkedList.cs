using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2026
{
    public class MyStackLinkedList<T> : IMyStack<T>
    {

        private LinkedList<T> values = new LinkedList<T>();
        
        public T Peek()
        {
            return values.Last();
        }

        public T Pop()
        {
            T temp =values.Last();
            values.RemoveLast();
            return temp ;
        }

        public void Push(T element)
        {
            values.AddLast(element);
        }
    }
}
