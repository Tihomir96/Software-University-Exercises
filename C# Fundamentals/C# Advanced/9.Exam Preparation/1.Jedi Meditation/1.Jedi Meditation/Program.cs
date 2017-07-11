using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Jedi_Meditation
{
    class Program
    {
        static void Main()
        {
            bool yoda = false;
            var masters = new Queue<string>();
            var knights = new Queue<string>();
            var padawans = new Queue<string>();
            var toshkoSlav =new Queue<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j].StartsWith("m"))
                    {
                        masters.Enqueue(line[j]);
                    }
                    else if (line[j].StartsWith("k"))
                    {
                        knights.Enqueue(line[j]);
                    }
                    else if (line[j].StartsWith("p"))
                    {
                        padawans.Enqueue(line[j]);
                    }
                    else if (line[j].StartsWith("y"))
                    {
                        yoda = true;
                    }
                    else if (line[j].StartsWith("t"))
                    {
                        toshkoSlav.Enqueue(line[j]);
                    }
                    else if (line[j].StartsWith("s"))
                    {
                        toshkoSlav.Enqueue(line[j]); 
                    }
                }
               
            }
            if (yoda)
            {
                PrintQueue(masters);
                PrintQueue(knights);
                PrintQueue(toshkoSlav);
                PrintQueue(padawans);
            }
            else
            {
                PrintQueue(toshkoSlav);
                PrintQueue(masters);
                PrintQueue(knights);
                PrintQueue(padawans);
            }
        }
        public static void PrintQueue(Queue<string> jediQueue)
        {
            while (jediQueue.Count!=0)
            {
                Console.Write(jediQueue.Dequeue()+" ");
            }
        }
    }
}
