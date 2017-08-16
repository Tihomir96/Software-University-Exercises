using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = Type.GetType("BlackBoxInt");
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                var tokens = input.Split('_');
                switch (tokens[0])
                {
                    case "Add":
                        var addMethod = classType.GetMethods().FirstOrDefault(x => x.Name == "Add");
                        addMethod.Invoke(tokens[1], )
                            addMethod.
                            break;
                }
            }

        }
    }
}
