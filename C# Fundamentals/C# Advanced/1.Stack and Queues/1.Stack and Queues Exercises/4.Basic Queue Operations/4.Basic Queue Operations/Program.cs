using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToAdd = input[0];
            int elementsToPop = input[1];
            int x = input[2];

            var queue = new Queue<int>();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToAdd; i++)
            {
                queue.Enqueue(secondInput[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
