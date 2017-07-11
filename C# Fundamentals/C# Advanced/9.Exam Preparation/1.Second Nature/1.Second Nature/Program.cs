namespace _1.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {            
            var flowersQueue = new Queue<int>(Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var bucketStack = new Stack<int>(Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));     
            var secondNature = new Queue<int>();
            var waterToAdd = 0;
            var flowersToRemove = 0;
            while (bucketStack.Count !=0 && flowersQueue.Count !=0 )
            {
                var waterLeft = bucketStack.Peek()-flowersQueue.First();
                if (waterLeft > 0)
                {
                    if (bucketStack.Count > 0)
                    {
                        bucketStack.Pop();
                        flowersQueue.Dequeue();
                        if (bucketStack.Count > 0)
                        {
                            waterToAdd = waterLeft + bucketStack.Pop();
                            bucketStack.Push(waterToAdd);
                        }
                        else
                        {
                            bucketStack.Push(waterLeft);
                        }
                    }
                    else
                    {
                        flowersQueue.Dequeue();
                        bucketStack.Push(waterLeft);
                    }
                    
                }
                else if (waterLeft == 0)
                {                    
                    secondNature.Enqueue(flowersQueue.First());
                    flowersQueue.Dequeue();
                    bucketStack.Pop();
                }6
                else
                {
                    flowersToRemove = flowersQueue.First() - Math.Abs(waterLeft);
                    flowersQueue.Dequeue();
                    flowersQueue.Enqueue(flowersToRemove);                    
                }
            }
            if (bucketStack.Count > 0)
            {
                Console.WriteLine(string.Join(" ", bucketStack));
                if (secondNature.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", secondNature));
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ",flowersQueue));
                if (secondNature.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", secondNature));
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
       
    }
}
