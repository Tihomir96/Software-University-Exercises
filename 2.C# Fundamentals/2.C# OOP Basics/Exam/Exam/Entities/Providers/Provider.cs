
using System;

public abstract class Provider
{
    protected Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    private string id;

    
    private double energyOutput;

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"EnergyOutput");
            }
            this.energyOutput = value;
        }
    }
    public string Id { get { return this.id; } }



}

