using System;

namespace _1.Event_Impl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChange +=handler.OnDispatcherNameChange;
            var input = Console.ReadLine();
            while (input!="End")
            {
                dispatcher.Name = input;
                input = Console.ReadLine();
            }
        }
    }
}
