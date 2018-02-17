using System;

namespace _2.KingsGambit
{
    public class King
    {
        public event EventHandler UnderAtack;

        public King(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public void OnUnderAtack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            if (UnderAtack != null)
            {
                UnderAtack(this,new EventArgs());
            }
            
        }
    }
}
