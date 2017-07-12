using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }
        var n = int.Parse(Console.ReadLine());
        var member = new Person();
        var family = new Family();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            member.Name = name;
            member.Age = age;
            family.AddMember(member);
        }
        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");

    }
}