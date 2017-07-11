using System.Collections.Generic;

namespace _13.Office_Stuff
    {
        using System;
        using System.Collections.Generic;
        using System.Text;
        using System.Linq;
    class Program
        {
            static void Main()
            {
                var n = int.Parse(Console.ReadLine());
                var dict = new Dictionary<string,Products>();
                var products = new Products();
                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine().Split(new []{ '|', ' ', '-' },StringSplitOptions.RemoveEmptyEntries);
                    var company = input[0];
                    var amount = int.Parse(input[1]);
                    var product = input[2];
                    if (!dict.ContainsKey(input[0]))
                    {
                        products=new Products();
                        products.productAmount.Add(product, amount);
                        dict.Add(company, products);
                    }
                    else
                    {
                        if (dict[company].productAmount.ContainsKey(product))
                        {
                            dict[company].productAmount[product] += amount; 
                        }
                        else
                        {
                           dict[company].productAmount.Add(product,amount);
                        }
                    
                    }
                }
            
                var sb = new StringBuilder();
                foreach (var company in dict)
                {
                  sb.Append($"{company.Key}:");
                  // foreach (var entry in company.Value.productAmount)
                  // {
                  //     //entry.Value
                  //     sb.Append(' ');
                  //     sb.Append(entry.Key);
                  //     sb.Append('-');
                  //     sb.Append(entry.Value);
                  //     sb.Append(',');
                  // }
                    company.Value.productAmount.ToList().ForEach(x=>sb.Append(' ').Append(x.Key).Append('-').Append(x.Value).Append(','));
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(Environment.NewLine);

                }

                Console.WriteLine(sb);   
            }
        }

    }
    class Products
    {
        public Dictionary<string, int> productAmount { get; set; } = new Dictionary<string, int>();
    }
