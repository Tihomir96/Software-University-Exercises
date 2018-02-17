using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CommandInterpreter
    {
        private MyCustomList<string> myList = new MyCustomList<string>();
        public void InterpredCommand(string input)
        {
            var tokens = input.Split(' ');
            var command = tokens[0];

            switch (command)
            {
                case "Add":
                    var element = tokens[1];
                    myList.Add(element);
                    break;

                case "Remove":
                    var index = int.Parse(tokens[1]);
                    myList.Remove(index);
                    break;

                case "Contains":
                    element = tokens[1];
                    Console.WriteLine(myList.Contains(element));
                    break;

                case "Swap":
                    var firstIndex = int.Parse(tokens[1]);
                    var secondIndex = int.Parse(tokens[2]);
                    myList.Swap(firstIndex, secondIndex);
                    break;

                case "Greater":
                    element = tokens[1];
                    Console.WriteLine(myList.CountGreaterElements(element));
                    break;

                case "Max":
                    Console.WriteLine(myList.Max());
                    break;

                case "Min":
                    Console.WriteLine(myList.Min());
                    break;

                case "Print":
                    Console.WriteLine(myList.Print());
                    break;
                case "Sort":
                    myList.Sort();
                    break;
            }
        }
    }
}
