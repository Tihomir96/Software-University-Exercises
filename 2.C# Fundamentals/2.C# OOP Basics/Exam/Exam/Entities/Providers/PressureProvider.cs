
using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput = this.EnergyOutput + ((this.EnergyOutput * 50) / 100);
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Pressure  Provider - {this.Id}");
        sb.Append($"Energy Output: {this.EnergyOutput:f0}");
        return sb.ToString().Trim();
    }
}


