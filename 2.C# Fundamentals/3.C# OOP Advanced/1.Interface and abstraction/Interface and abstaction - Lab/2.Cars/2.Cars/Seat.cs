using System.Text;

public class Seat:ICar
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

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine($"{this.Start()}");
        sb.Append($"{this.Stop()}");
        return sb.ToString().Trim();
    }
}


