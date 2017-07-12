using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var legendaryDict = new Dictionary<string, int>();
            var dict = new Dictionary<string, int>();
            bool legendaryObtained = false;
            legendaryDict.Add("fragments", 0);
            legendaryDict.Add("motes", 0);
            legendaryDict.Add("shards", 0);

            while (!legendaryObtained)
            {
                for (int i = 0; i < input.Length; i += 2)
                {


                    var quantity = input[i];
                    var material = input[i + 1].ToString().ToLower();

                    if ((material == "shards" || material == "motes" || material == "fragments"))
                    {

                        if (!legendaryDict.ContainsKey(material))
                        {
                            legendaryDict.Add(material, int.Parse(quantity));
                            if (IsQuantityEnought(legendaryDict[material]) && (material == "shards" || material == "motes" || material == "fragments"))
                            {
                                if (material == "shards")
                                {

                                    legendaryDict[material] -= 250;
                                    Console.WriteLine("Shadowmourne obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;

                                }
                                else if (material == "fragments")
                                {
                                    legendaryDict[material] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;

                                }
                                else
                                {
                                    legendaryDict[material] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;


                                }
                            }
                        }
                        else
                        {
                            legendaryDict[material] += int.Parse(quantity);
                            if (IsQuantityEnought(legendaryDict[material]) && (material == "shards" || material == "motes" || material == "fragments"))
                            {
                                if (material == "shards")
                                {
                                    legendaryDict[material] -= 250;

                                    Console.WriteLine("Shadowmourne obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;


                                }
                                else if (material == "motes")
                                {
                                    legendaryDict[material] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;


                                }
                                else
                                {
                                    legendaryDict[material] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                    Print(legendaryDict, dict);
                                    legendaryObtained = true;
                                    return;

                                }

                            }


                        }
                    }
                    else
                    {
                        if (!dict.ContainsKey(material))
                        {
                            dict.Add(material, int.Parse(quantity));
                        }
                        else
                        {
                            dict[material] += int.Parse(quantity);
                        }
                    }

                }

                input = Console.ReadLine().Split(' ');

            }
        }

        private static void Print(Dictionary<string, int> legendaryDict, Dictionary<string, int> junkDict)
        {
            foreach (var item in legendaryDict.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        private static bool IsQuantityEnought(int quantity)
        {
            if (quantity >= 250)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
