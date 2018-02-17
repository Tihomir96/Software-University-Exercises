public class EarthBender : Bender
{
    private double groundSaturation;
    public double GroundSaturation
    {
        get { return this.groundSaturation; }
    }

    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }
}


