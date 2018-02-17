public class WaterBender : Bender
{
    private double waterClarity;
    public double WaterClarity
    {
        get { return this.waterClarity; }
    }

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.waterClarity = waterClarity;

    }
}


