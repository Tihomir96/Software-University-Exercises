using System;

public class Program
{
    static void Main()
    {
        var spy = new Spy();

        //1.Stealer

        //Console.WriteLine(spy.StealFieldInfo("Hacker", "username", "password"));

        //2.High Quality Mistakes

        //Console.WriteLine(spy.AnalyzeAcessModifiers("Hacker"));

        //3.Mission Private Impossible

        //Console.WriteLine(spy.RevealPrivateMethods("Hacker"));
        
        //4.Collector

        Console.WriteLine(spy.CollectGettersAndSetters("Hacker"));
    }
}
