public class EarthMonument : Monument
{
    private int earthAffinity;

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
    }

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.earthAffinity = earthAffinity;
    }


}

