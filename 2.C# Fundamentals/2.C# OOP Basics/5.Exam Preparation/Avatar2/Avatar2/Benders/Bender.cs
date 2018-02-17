public abstract class Bender
{
    private string name;
    private int power;
    public string Name { get { return this.name; } }
    public int Power { get { return this.power; } }

    protected Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }



}




