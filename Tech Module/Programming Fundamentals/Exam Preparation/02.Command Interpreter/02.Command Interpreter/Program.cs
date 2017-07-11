using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (commands[0] != "end")
            {
                var command = commands[0];
                if (command == "reverse")
                {
                    int reverseStart = int.Parse(commands[2]);
                    int reverseCount = int.Parse(commands[4]);
                    if (isValid(array, reverseStart, reverseCount))
                    {
                        ReverseArray(array, reverseStart, reverseCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "sort")
                {
                    int sortStart = int.Parse(commands[2]);
                    int sortCount = int.Parse(commands[4]);
                    if (isValid(array, sortStart, sortCount))
                    {
                        SortArray(array, sortStart, sortCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                else if (command == "rollLeft")
                {
                    int rollLeft = int.Parse(commands[1]);
                    if (rollLeft >= 0)
                    {
                        RollLeft(array, rollLeft);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");                      
                    }
                }
                else if (command == "rollRight")
                {
                    int rollRight = int.Parse(commands[1]);
                    if (rollRight >= 0)
                    {
                        RollRight(array, rollRight);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                commands= Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine($"[{string.Join(", ",array)}]");

        }

        private static void RollRight(List<string> array, int rollRight)
        {
            rollRight = rollRight % array.Count;

            for (int i = 0; i < rollRight; i++)
            {
                var lastElement = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);

                array.Insert(0, lastElement);
            }
        }

        private static void RollLeft(List<string> array, int rollLeft)
        {
            rollLeft = rollLeft % array.Count;
            for (int i = 0; i < rollLeft; i++)
            {
                var firstElement = array[0];
                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = firstElement;
            }
        }

        private static void SortArray(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
        }

        private static void ReverseArray(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }

        private static bool isValid(List<string> array, int start, int count)
        {
            if (start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count)
            {
                return true;
            }
            return false;
        }
    }
}

