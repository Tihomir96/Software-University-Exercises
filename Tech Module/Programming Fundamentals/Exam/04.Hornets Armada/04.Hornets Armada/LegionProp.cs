using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornets_Armada
{
    class LegionProp
    {
        public int LastActivity { get; set; }
        public Dictionary<string,long> SoldierType { get; set; } = new Dictionary<string,long>();
        public long SoldierCount { get; set; }
    }
}
