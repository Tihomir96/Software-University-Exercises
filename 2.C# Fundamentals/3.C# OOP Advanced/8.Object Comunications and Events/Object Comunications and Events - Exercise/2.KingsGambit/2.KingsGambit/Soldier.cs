using System;
using System.Collections.Specialized;

namespace _2.KingsGambit
{
    public abstract class Soldier
    {
        protected Soldier(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public abstract void KingUnderAtack(object sender, EventArgs args);
    }
}
