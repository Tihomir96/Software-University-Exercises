using System;

namespace _2.KingsGambit
{
    public class RoyalGuard:Soldier
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void KingUnderAtack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
