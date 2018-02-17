using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CommandInterpreter reader = new CommandInterpreter();
            var input = Console.ReadLine();
            while (input!="END")
            {
                reader.InterpredCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}
