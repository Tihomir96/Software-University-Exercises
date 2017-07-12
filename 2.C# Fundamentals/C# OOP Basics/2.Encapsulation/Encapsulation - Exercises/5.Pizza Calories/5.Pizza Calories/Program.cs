using System;

namespace _5.Pizza_Calories
{
    class Program
    {
        static void Main()
        {
            string inputLine;
            while ((inputLine=Console.ReadLine())!="END")
            {
                var tokens = inputLine.Split();
                try
                {
                    
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dough= new Dough(tokens[1],tokens[2],double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetCalories():F2}");
                            break;
                        case "Pizza":
                            if (int.Parse(tokens[2]) > 10 || int.Parse(tokens[2]) < 0)
                            {
                                Console.WriteLine("Number of toppings should be in range [0..10].");
                                return;
                            }
                            MakePizza(tokens);
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1],double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
                                           
                     
        }
        private static void MakePizza(string[]tokens)
        {            
            var doughInfo = Console.ReadLine().Split();
            var dough = new Dough(doughInfo[1],doughInfo[2],double.Parse(doughInfo[3]));
            var pizza = new Pizza(tokens[1],dough,int.Parse(tokens[2]));
            for (int i = 0; i < int.Parse(tokens[2]); i++)
            {
                var toppings = Console.ReadLine().Split();
                var topping = new Topping(toppings[1],double.Parse(toppings[2]));
                pizza.AddTopping(topping);
            }
            Console.WriteLine($"{pizza.Name} = {pizza.GetCalories():f2} Calories.");            
        }
    }
}
