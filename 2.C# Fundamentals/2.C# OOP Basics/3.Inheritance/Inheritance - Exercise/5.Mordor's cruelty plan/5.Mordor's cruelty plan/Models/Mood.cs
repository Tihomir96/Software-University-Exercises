
namespace _5.Mordor_s_cruelty_plan.Models
{
    public abstract class Mood
    {
        public Mood(string moodName)
        {
            this.MoodName = moodName;
        }

        public override string ToString()
        {
            return this.MoodName;
        }

        public string MoodName { get; set; }
    }
}
