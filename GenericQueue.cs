using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class GenericQueue<T> : Queue<T>
    {
        // Queue to hold items of type T
        private Queue<T> queue = new Queue<T>();
        // Method to enqueue an item
        public void EnqueueItem(T item)
        {
            queue.Enqueue(item);
            Console.WriteLine($"Item enqueued: {item}");
        }
        // Method to dequeue an item
        public T DequeueItem()
        {
            if (queue.Count > 0)
            {
                T item = queue.Dequeue();
                Console.WriteLine($"Item dequeued: {item}");
                return item;
            }
            else
            {
                Console.WriteLine("Queue is empty. Cannot dequeue item.");
                return default(T);
            }
        }
        // Method to display all items in the queue
        public void DisplayQueue()
        {
            Console.WriteLine("Queue contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
