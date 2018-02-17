﻿public class AirMonument : Monument
{
    private int airAffinity;

    public int AirAffinity
    {
        get { return this.airAffinity; }
    }

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.airAffinity = airAffinity;
    }


}

