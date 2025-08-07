using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class Loops
    {
        public Loops()
        {
        }
        public void ForLoopExample()
        {
            Console.WriteLine("For Loop Example: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void WhileLoopExample()
        {
            Console.WriteLine("While Loop Example: ");
            int i = 1;
            while (i <= 10)
            {
                Console.Write($"{i},");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void DoWhileLoopExample()
        {
            Console.WriteLine("Do-While Loop Example: ");
            int i = 1;
            do
            {
                Console.Write($"{i},");
                i++;
            } while (i <= 10);
            Console.WriteLine();
        }
       
    }
}
