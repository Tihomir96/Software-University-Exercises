using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomber = bomb[0];
            int deadNumbers = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomber == numbers[i])
                {
                    if (deadNumbers > i)
                    {
                        if (i + deadNumbers + 1 > numbers.Count)
                        {
                            numbers.RemoveRange(0, numbers.Count);
                        }
                        else
                        {
                            numbers.RemoveRange(0, i + deadNumbers + 1);
                        }
                    }
                    else if (i + deadNumbers > numbers.Count)
                    {
                        numbers.RemoveRange(i - deadNumbers, numbers.Count - i + deadNumbers);
                    }
                    else
                    {
                        numbers.RemoveRange(i - deadNumbers, 2 * deadNumbers + 1);
                    }
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}

