using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            int money = 50;
            int hotels = 0;
            int productPrice = 0;
            int turns = 0;
            var matrix = new char[rows][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[cols];
                var input = Console.ReadLine();
                matrix[i] = input.ToCharArray();
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        
                        if (matrix[i][j] == 'H')
                        {
                            hotels++;
                            if (money < 0)
                            {
                                Console.WriteLine($"Bought a hotel for 0. Total hotels: {hotels}.");
                            }
                            else
                            {
                                Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");                             
                            }
                            money = 0;
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                        }
                        else if (matrix[i][j] == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 3;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                                money += 10 * hotels;
                                money += 10 * hotels;
                            }
                        }
                        else if (matrix[i][j] == 'F')
                        {
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                            continue;
                            
                        }
                        else if (matrix[i][j] == 'S')
                        {
                            productPrice = (i + 1) * (j + 1);
                            if (money < 0)
                            {
                                Console.WriteLine($"Spent 0 money at the shop.");
                            }
                            else
                            {
                                Console.WriteLine($"Spent {productPrice} money at the shop.");                                
                                money -= productPrice;
                            }
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                        }
                        

                    }
                }
                else
                {
                    for (int j = matrix[i].Length - 1; j >= 0; j--)
                    {
                        
                        if (matrix[i][j] == 'H')
                        {
                            hotels++;
                            if (money < 0)
                            {
                                Console.WriteLine($"Bought a hotel for 0. Total hotels: {hotels}.");
                            }
                            else
                            {
                                 Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");                                
                            }
                            money = 0;                            
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                        }
                        else if (matrix[i][j] == 'J')
                        {
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 3;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                                money += 10 * hotels;
                                money += 10 * hotels;
                            }

                        }
                        else if (matrix[i][j] == 'F')
                        {
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                            continue;
                        }
                        else if (matrix[i][j] == 'S')
                        {
                            productPrice = (i + 1) * (j + 1);
                            if (money < 0)
                            {
                                Console.WriteLine($"Spent 0 money at the shop.");
                            }
                            else
                            {
                                Console.WriteLine($"Spent {productPrice} money at the shop.");                                
                                money -= productPrice;
                            }
                            turns++;
                            if (hotels > 0)
                            {
                                money += 10 * hotels;
                            }
                        }
                        
                    }
                }
            }
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}

