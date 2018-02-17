using System;

namespace _2.KingsGambit
{
    public class Footman:Soldier
    {
        public Footman(string name) : base(name)
        {
        }

        public override void KingUnderAtack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
