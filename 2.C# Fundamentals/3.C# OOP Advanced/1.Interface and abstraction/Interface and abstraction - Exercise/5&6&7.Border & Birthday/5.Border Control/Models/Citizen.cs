using System.Security.AccessControl;
using _5.Border_Control.Interfaces;

namespace _5.Border_Control
{
    public class Citizen:IIdentifiable,IBreathable,IBuyer
    {        
        public string id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }

        public Citizen(string name, int age, string id,string birthDate)
        {
            this.id = id;
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthDate;
        }

        public static int totalFood;

        public Citizen()
        {
            
        }
        public void BuyFood()
        {
            totalFood += 10;
        }


        public int Food
        {
            get
            {
                return totalFood;
            }
            
        }

    }
}
