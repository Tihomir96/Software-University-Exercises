
using System.Collections.Generic;

public class Nation
{
    private List<FireBender> fireNation;
    private List<WaterBender> waterNation;
    private List<EarthBender> earthNation;
    private List<AirBender> airNation;
    private List<FireMonument> fireMonuments;

    public List<FireMonument> FireMonuments
    {
        get { return this.fireMonuments; }
        protected set { this.fireMonuments = value; }
    }

    private List<WaterMonument> waterMonuments;

    public List<WaterMonument> WaterMonuments
    {
        get { return this.waterMonuments; }
        protected set { this.waterMonuments = value; }
    }

    private List<EarthMonument> earthMonuments;

    public List<EarthMonument> EarthMonuments
    {
        get { return this.earthMonuments; }
        protected set { this.earthMonuments = value; }
    }

    private List<AirMonument> airMonuments;

    public List<AirMonument> AirMonuments
    {
        get { return this.airMonuments; }
        protected set { this.airMonuments = value; }
    }

    public Nation()
    {
        this.AirNation = new List<AirBender>();
        this.AirMonuments = new List<AirMonument>();

        this.EarthNation = new List<EarthBender>();
        this.EarthMonuments = new List<EarthMonument>();

        this.FireNation = new List<FireBender>();
        this.FireMonuments = new List<FireMonument>();

        this.WaterNation = new List<WaterBender>();
        this.WaterMonuments = new List<WaterMonument>();
    }



    public List<FireBender> FireNation
    {
        get { return this.fireNation; }
        protected set { this.fireNation = value; }
    }

    public List<WaterBender> WaterNation
    {
        get { return this.waterNation; }
        protected set { this.waterNation = value; }
    }

    public List<AirBender> AirNation
    {
        get { return this.airNation; }
        protected set { this.airNation = value; }
    }
    public List<EarthBender> EarthNation
    {
        get { return this.earthNation; }
        protected set { this.earthNation = value; }
    }


    public double TotalPowerFire()
    {
        double sum = 0;
        foreach (var bender in this.fireNation)
        {
            sum += bender.Power * bender.HeatAgression;
        }
        double monumentSum = 0;
        foreach (var fireMonument in this.fireMonuments)
        {
            monumentSum += fireMonument.FireAffinity;
        }
        return sum + ((sum / 100) * monumentSum);
    }

    public double totalPowerWater()
    {
        double sum = 0;
        foreach (var bender in this.waterNation)
        {
            sum += bender.Power * bender.WaterClarity;
        }
        double monumentSum = 0;
        foreach (var monument in this.WaterMonuments)
        {
            monumentSum += monument.WaterAffinity;
        }
        return sum + ((sum / 100) * monumentSum);
    }
    public double totalPowerEarth()
    {
        double sum = 0;
        foreach (var bender in this.earthNation)
        {
            sum += bender.Power * bender.GroundSaturation;
        }
        double monumentSum = 0;
        foreach (var earthMonument in this.earthMonuments)
        {
            monumentSum += earthMonument.EarthAffinity;
        }
        return sum + ((sum / 100) * monumentSum);
    }
    public double totalPowerAir()
    {
        double sum = 0;
        foreach (var bender in this.airNation)
        {
            sum += bender.Power * bender.AerialIntegrity;
        }
        double monumentSum = 0;
        foreach (var airMonument in this.AirMonuments)
        {
            monumentSum += airMonument.AirAffinity;
        }
        return sum + ((sum / 100) * monumentSum);
    }
}

