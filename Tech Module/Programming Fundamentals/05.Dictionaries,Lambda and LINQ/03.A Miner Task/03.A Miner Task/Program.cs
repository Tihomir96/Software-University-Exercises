using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            var minerTask = new Dictionary<string, int>();

            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            while (resource != "stop")
            {

                if (!minerTask.ContainsKey(resource))
                {
                    minerTask.Add(resource, quantity);
                    
                }
                else 
                {
                    minerTask[resource] = minerTask[resource] + quantity;
                }
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    foreach (var item in minerTask)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                        return;
                }
                quantity = int.Parse(Console.ReadLine());

            }

        }
    }
}
