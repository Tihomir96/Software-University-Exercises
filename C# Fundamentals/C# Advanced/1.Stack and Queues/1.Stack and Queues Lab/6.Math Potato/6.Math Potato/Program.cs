namespace _6.Math_Potato
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var queue = new Queue<string>(input.Split(' '));
            var num = int.Parse(Console.ReadLine());

            int cycle = 1;
            while (queue.Count > 1)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                
                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            //if (number == 6737626471) return true;

            if (number % 2 == 0) return false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }

    }
   
