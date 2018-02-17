
using System;

public abstract class Harvester
{
    private string id;

    
    private double oreOutput;

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"OreOutput");
            }
            this.oreOutput = value;
        }
    }
    private double energyRequirement;

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }

    public string Id {
        get { return this.id; }
    }
    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }





}

