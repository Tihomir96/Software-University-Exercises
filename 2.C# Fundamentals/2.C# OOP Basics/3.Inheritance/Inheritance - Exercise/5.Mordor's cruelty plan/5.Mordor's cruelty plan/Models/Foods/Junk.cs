using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Mordor_s_cruelty_plan.Models.Foods
{
    public class Junk:Food
    {
        private const int HapinessPoints = -1;
        public Junk() : base(HapinessPoints)
        {
        }
    }
}
