public class FireBender : Bender
{
    private double heatAgression;
    public double HeatAgression
    {
        get { return this.heatAgression; }
    }


    public FireBender(string name, int power, double heatAgression) : base(name, power)
    {
        this.heatAgression = heatAgression;

    }
}


