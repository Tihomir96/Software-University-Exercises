
    using System.Collections.Generic;

public class Ranker:Soldier,ISoldier
    {
        public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
        {
        }

        protected override IReadOnlyList<string> WeaponsAllowed { get; }
    }

