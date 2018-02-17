using _5.Mordor_s_cruelty_plan.Models;
using _5.Mordor_s_cruelty_plan.Models.Foods;

namespace _5.Mordor_s_cruelty_plan.Factories
{
    public class FoodFactory
    {
        public Food GetFood(string foodType)
        {
            switch (foodType.ToLower())
            {
                case "cram":
                    return new Cram();
                    break;
                case "lembas":
                    return new Lembas();
                    break;
                case "melon":
                    return new Melon();
                case "apple":
                    return new Apple();
                case"honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Junk();

            }
        }
    }
}
