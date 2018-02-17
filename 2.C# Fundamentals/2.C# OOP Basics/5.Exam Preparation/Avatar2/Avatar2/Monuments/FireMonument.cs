public class FireMonument : Monument
{
    private int fireAffinity;

    public int FireAffinity
    {
        get { return this.fireAffinity; }
    }

    public FireMonument(string name, int fireAffinity) : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

}

