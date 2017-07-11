using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            var dict = new SortedDictionary<string, int>();
            var junkdict = new SortedDictionary<string, int>();
            bool itemNotFound = true;
            dict.Add("fragments",0);
            dict.Add("motes", 0);
            dict.Add("shards",0);
            while (itemNotFound)
            {
                var input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var item = input[i + 1].ToString().ToLower();

                    if (item.ToLower() == "shards")
                    {
                        if (dict.ContainsKey(item))
                        {
                            dict[item] += quantity;
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;
                            }
                        }
                        else
                        {
                            dict.Add(item, quantity);
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;                                
                            }
                            else
                            {
                                itemNotFound = true;
                            }
                        }
                    }
                    else if (item.ToLower() == "fragments")
                    {
                        if (dict.ContainsKey(item))
                        {
                            dict[item] += quantity;
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;
                            }
                            else
                            {
                                itemNotFound = true;
                            }
                        }
                        else
                        {
                            dict.Add(item, quantity);
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;
                            }
                            else
                            {
                                itemNotFound = true;
                            }
                        }
                    }
                    else if (item.ToLower() == "motes")
                    {
                        if (dict.ContainsKey(item))
                        {
                            dict[item] += quantity;
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;
                            }
                            else
                            {
                                itemNotFound = true;
                            }
                        }
                        else
                        {
                            dict.Add(item, quantity);
                            if (dict[item] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                dict[item] -= 250;
                                itemNotFound = false;
                                PrintDict(dict, junkdict);
                                return;
                            }
                            else
                            {
                                itemNotFound = true;
                            }
                        }
                    }
                    else
                    {
                        if (junkdict.ContainsKey(item))
                        {
                            junkdict[item] += quantity;
                            itemNotFound = true;
                        }
                        else
                        {
                            junkdict.Add(item, quantity);
                            itemNotFound = true;
                        }
                    }

                }
            }           
        }

        private static void PrintDict(SortedDictionary<string, int> dict, SortedDictionary<string, int> junkdict)
        {
            foreach (var material in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }            
            foreach (var junk in junkdict.OrderBy(x => x.Key))
            {
                
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }

        }
    }
}