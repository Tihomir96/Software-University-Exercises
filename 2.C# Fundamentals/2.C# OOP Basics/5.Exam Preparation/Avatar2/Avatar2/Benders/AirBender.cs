public class AirBender : Bender
{
    private double aerialIntegrity;
    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
    }

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.aerialIntegrity = aerialIntegrity;
    }
}



