using System;

public class Program
{
    public static void Main()
    {
        var scale = new Scale<int>(3,5);
        Console.WriteLine(scale.GetHavier(3,5));

    }
}
