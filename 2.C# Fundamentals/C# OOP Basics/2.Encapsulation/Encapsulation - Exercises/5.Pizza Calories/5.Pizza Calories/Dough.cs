using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Pizza_Calories
{
   public  class Dough
    {
        private string flourType;
        private string bakingTechnique;

        private double weight;

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double GetCalories()
        {
            return 2 * this.weight *this.GetTechModifier() *this.GetTypeMode();
        }

        private double GetTypeMode()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;
            }
            return 1.0;

        }

        private double GetTechModifier()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }
            else
            {
                return 1;
            }
        }



    }
}
        
    

