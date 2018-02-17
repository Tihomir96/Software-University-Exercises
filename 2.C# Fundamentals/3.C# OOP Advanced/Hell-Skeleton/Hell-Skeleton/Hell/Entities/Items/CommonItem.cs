using System;

public class CommonItem : AbstractItem
{
    public CommonItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus) 
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
       
    }
    public string Name { get; }

    public long StrengthBonus { get; }

    public long AgilityBonus { get; }

    public long IntelligenceBonus { get; }

    public long HitPointsBonus { get; }

    public long DamageBonus { get; }
}

