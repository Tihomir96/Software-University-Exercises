using System.Text;

class Tesla : IElectricCar,ICar
{
    public string Model { get; }
    public string Color { get; }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public int Battery { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        sb.AppendLine($"{this.Start()}");
        sb.Append($"{this.Stop()}");
        return sb.ToString().Trim();
    }
}


