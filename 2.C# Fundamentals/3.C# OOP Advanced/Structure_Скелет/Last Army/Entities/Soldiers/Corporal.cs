    using System.Collections.Generic;

public class Corporal:Soldier
    {
        public Corporal(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
        {
        }

        protected override IReadOnlyList<string> WeaponsAllowed { get; }
    }

