public class WaterMonument : Monument
{
    private int waterAffinity;

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
    }

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.waterAffinity = waterAffinity;
    }
}

