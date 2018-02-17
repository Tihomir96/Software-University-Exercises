
using _5.Mordor_s_cruelty_plan.Models;
using _5.Mordor_s_cruelty_plan.Models.Moods;

namespace _5.Mordor_s_cruelty_plan.Factories
{
    public class MoodFactory
    {
        public Mood GetMood(int happinesPoints)
        {
            if (happinesPoints < -5)
            {
                return new Angry();
            }
            if (happinesPoints <= 0)
            {
                return new Sad();
            }
            if (happinesPoints <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();                
            }
        }
    
    }
}
