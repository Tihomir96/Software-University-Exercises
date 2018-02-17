
using System.Text;

public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput) : base(id, energyOutput)
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Solar Provider - {this.Id}");
        sb.Append($"Energy Output: {this.EnergyOutput:f0}");
        return sb.ToString().Trim();
    }
}

