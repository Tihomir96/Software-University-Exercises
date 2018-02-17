public abstract class Ammunition:IAmmunition,IWareHouse
{
    protected Ammunition(string name,double weight,int number)
    {
        this.Number = number;
        this.Name = name;
        this.Weight = weight;
    }
    public string Name { get; set; }
    public double Weight { get; set; }
    public double WearLevel { get; }
    public int Number { get; set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        //TODO
    }

    public void EquipArmy(IArmy army)
    {
        //TODO
    }
}

