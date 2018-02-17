
using System;

public class Program
{
    public static void Main()
    {
        var calc = new PrimitiveCalculator();
        var input = Console.ReadLine().Split();
        while (input[0]!="End")
        {
            if (input[0] == "mode")
            {
                calc.changeStrategy(char.Parse(input[1]));
            }
            else
            {
                Console.WriteLine(calc.performCalculation(int.Parse(input[0]),int.Parse(input[1])));
            }
            input = Console.ReadLine().Split();
        }
    }
}

