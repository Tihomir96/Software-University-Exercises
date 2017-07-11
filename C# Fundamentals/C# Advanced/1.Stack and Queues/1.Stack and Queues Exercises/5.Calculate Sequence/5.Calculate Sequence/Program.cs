namespace _5.Calculate_Sequence
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(n);
            for (int i = 0; i < 50; i++)
            {
                var current = queue.Dequeue();
                Console.Write(current + " ");
                queue.Enqueue(current+1);
                queue.Enqueue(current*2+1);
                queue.Enqueue(current+2);
            }
        }
    }
}
