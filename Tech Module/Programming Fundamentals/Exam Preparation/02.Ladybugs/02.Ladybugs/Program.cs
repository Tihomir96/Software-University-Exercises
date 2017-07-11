namespace _02.Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var indexes = Console.ReadLine().Split(' ');
            var commands = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = 0;
            }
            for (int i = 0; i < indexes.Length; i++)
            {
                var index = int.Parse(indexes[i]);
                if (index > 0 && index < n)
                {
                    arr[index] = 1;
                }
            }
            while (commands[0] != "end")
            {
                var bugIndex = long.Parse(commands[0]);
                var direction = commands[1];
                var flyLength = long.Parse(commands[2]);
                if (bugIndex >= n || bugIndex < 0 || arr[bugIndex] == 0 || flyLength == 0)
                {

                    commands = Console.ReadLine().Split(' ');
                    continue;
                }
                arr[bugIndex] = 0;
                if (direction == "right")
                {
                    if (bugIndex + flyLength < n && bugIndex + flyLength >= 0)
                    {
                        if (arr[bugIndex + flyLength] == 0)
                        {
                            arr[bugIndex + flyLength] = 1;
                        }
                        else
                        {
                            for (long i = bugIndex + flyLength + 1; i < n; i += flyLength)
                            {
                                if (arr[i] == 0)
                                {
                                    arr[i] = 1;
                                    break;
                                }

                            }
                        }
                    }
                }
                else
                {
                    if (bugIndex - flyLength >= 0)
                    {
                        if (arr[bugIndex - flyLength] == 0)
                        {
                            arr[bugIndex - flyLength] = 1;

                        }
                        else
                        {
                            for (long i = bugIndex - flyLength; i >= 0; i -= flyLength)
                            {
                                if (arr[i] == 0)
                                {
                                    arr[i] = 1;
                                    break;
                                }
                            }
                        }
                    }

                }


                commands = Console.ReadLine().Split(' ');

            }
            Console.WriteLine(string.Join(" ", arr));


        }
    }
}
