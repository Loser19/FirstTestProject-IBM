using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    public delegate void Notify(string message);
    public delegate void CalcDelegate(int x, int y);
    internal class DelegatesDemo
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product: {x * y}");
        }
        public void Divide(int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine($"Division: {x / y}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        public event Notify NotifyEvent;
        public void TriggerEvent(string message)
        {
            NotifyEvent?.Invoke(message);
        }
        // The Notify Event is an event of type Notify, which is a delegate that takes a string parameter.
        public void Subscribe(Notify handler)
        {
            NotifyEvent += handler;                                                 // Subscribe to the event
        }
        public void Unsubscribe(Notify handler)
        {
            NotifyEvent -= handler;
            Console.WriteLine("Unsubscribed from the event.");
        }
    }
}
