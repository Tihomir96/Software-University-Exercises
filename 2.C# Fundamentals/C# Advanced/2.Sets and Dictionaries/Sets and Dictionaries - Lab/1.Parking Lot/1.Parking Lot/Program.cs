using System.Collections.Generic;

namespace _1.Parking_Lot
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var set = new SortedSet<string>();

            while (input[0]!="END")
            {
                if (input[0] == "IN")
                {
                    set.Add(input[1]);
                }
                else
                {
                    if (set.Contains(input[1]))
                    {
                        set.Remove(input[1]); 
                    }
                }

                input= Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (set.Count != 0)
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
