using System.Linq;
using System.Reflection;

namespace _01HarestingFields
{
    using System;

    class HarvestingFieldsTest
    {
        static void Main()
        {
            string input;
            var classType = Type.GetType("_01HarestingFields.HarvestingFields");
            while ((input=Console.ReadLine())!="HARVEST")
            {
                switch (input)
                {
                    case "private":
                        
                        FieldInfo[] privateFields = classType.GetFields(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Static);

                        foreach (FieldInfo field in privateFields.Where(x=>x.IsPrivate))
                        {
                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "protected":
                        FieldInfo[] protectedFields =
                            classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

                        foreach (var field in protectedFields.Where(x=>x.IsFamily))
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "public":
                        FieldInfo[] publicFields =
                            classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

                        foreach (var field in publicFields)
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "all":
                        FieldInfo[] allfields =
                            classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic |
                                                BindingFlags.Static);

                        foreach (var field in allfields)
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            }
                            else if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                }
            }
        }
    }
}
