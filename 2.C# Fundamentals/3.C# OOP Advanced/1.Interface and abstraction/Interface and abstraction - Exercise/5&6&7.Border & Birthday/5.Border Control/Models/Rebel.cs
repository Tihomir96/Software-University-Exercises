using _5.Border_Control.Interfaces;

namespace _5.Border_Control
{
    public class Rebel:IBuyer
    {
        public static int totalFood;

        public Rebel()
        {
            
        }
        public void BuyFood()
        {
            totalFood += 5;
            
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Food
        {
            get { return totalFood; }
            
        }

        public Rebel(string name, int age)
        {
            this.Name = name;
            this.Age = age;            
        }
    }
}
