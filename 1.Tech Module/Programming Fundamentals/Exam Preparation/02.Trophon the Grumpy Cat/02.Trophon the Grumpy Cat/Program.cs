using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main()
        {

            var priceRatings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var typeOfPriceRatings = Console.ReadLine();
            BigInteger leftSum = 0;
            int border = priceRatings[entryPoint];
            for (int i = 0; i <entryPoint ; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if(priceRatings[i] < border) 
                    {
                        if(typeOfPriceRatings == "all")
                        {
                            leftSum += priceRatings[i];
                        }
                        else if (typeOfPriceRatings == "negative")
                        {
                            if (priceRatings[i] < 0)
                            {
                                leftSum += priceRatings[i];
                            }
                        }
                        else if (typeOfPriceRatings == "positive")
                        {
                            if (priceRatings[i] > 0)
                            {
                                leftSum += priceRatings[i];
                            }
                        }
                    }

                }else if (typeOfItems == "expensive")
                {
                    if (priceRatings[i] >= border)
                    {
                        if(typeOfPriceRatings == "all")
                        {
                            leftSum += priceRatings[i];

                        }else if (typeOfPriceRatings == "negative")
                        {
                            if (priceRatings[i] < 0)
                            {
                                leftSum += priceRatings[i];
                            }
                        }else if (typeOfPriceRatings == "positive")
                        {
                            if (priceRatings[i] > 0)
                            {
                                leftSum += priceRatings[i];
                            }
                        }
                    }
                }
            }
            BigInteger rightSum = 0;
            for (int i = entryPoint+1; i < priceRatings.Length; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (priceRatings[i] < border)
                    {
                        if (typeOfPriceRatings == "all")
                        {
                            rightSum += priceRatings[i];

                        }
                        else if (typeOfPriceRatings == "negative")
                        {
                            if (priceRatings[i] < 0)
                            {
                                rightSum += priceRatings[i];
                            }
                        }
                        else if (typeOfPriceRatings == "positive")
                        {
                            if (priceRatings[i] > 0)
                            {
                                rightSum += priceRatings[i];
                            }
                        }
                    }

                }
                else if (typeOfItems == "expensive")
                {
                    if (priceRatings[i] >= border)
                    {
                        if (typeOfPriceRatings == "all")
                        {
                            rightSum += priceRatings[i];

                        }
                        else if (typeOfPriceRatings == "negative")
                        {
                            if (priceRatings[i] < 0)
                            {
                                rightSum += priceRatings[i];
                            }
                        }
                        else if (typeOfPriceRatings == "positive")
                        {
                            if (priceRatings[i] > 0)
                            {
                                rightSum += priceRatings[i];
                            }
                        }
                    }
                }
            }
                if (leftSum >= rightSum)
                {
                    Console.WriteLine($"Left - {leftSum}");
                }else
                {
                    Console.WriteLine($"Right - {rightSum}");
                }

        }
    }
}
