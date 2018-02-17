namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ExitCommand
    {
        public string Execute()
        {
            Console.WriteLine($"Bye-Bye!");
            Environment.Exit(0);
            return null;
        }
    }
}
