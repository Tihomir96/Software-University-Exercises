namespace _5.Mordor_s_cruelty_plan.Models
{
    public abstract class Food
    {
        protected Food(int hapinessPoints)
        {
            this.HapinessPoints = hapinessPoints;
        }
        private int HapinessPoints { get; set; }

        public int GetHapinnesPoints()
        {
            return this.HapinessPoints;
        }
    }
}
