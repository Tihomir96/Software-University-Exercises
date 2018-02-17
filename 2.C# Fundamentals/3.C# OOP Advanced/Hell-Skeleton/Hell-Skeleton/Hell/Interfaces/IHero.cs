using System.Collections.Generic;

public interface IHero
{
    string Name { get; }
    long HitPoints { get; }
    long Damage { get; }
    long Strength { get;  }
    long Agility { get;  }
    long Intelligence { get; }
    void AddItem(IItem item);
    ICollection<IItem> Items { get; }
    long PrimaryStats { get; }
    long SecondaryStats { get; }
    void AddRecipe(IRecipe recipe);
}