using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class GenericStack<T> : Stack<T>
    {
        //push and pop of person details
        private Stack<T> stack = new Stack<T>();
        public void PushItem(T item)
        {
            stack.Push(item);
            Console.WriteLine($"Item pushed: {item}");
        }
        public T PopItem()
        {
            if (stack.Count > 0)
            {
                T item = stack.Pop();
                Console.WriteLine($"Item popped: {item}");
                return item;
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop item.");
                return default(T);
            }
        }
        public void DisplayStack()
        {
            Console.WriteLine("Stack contents:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
