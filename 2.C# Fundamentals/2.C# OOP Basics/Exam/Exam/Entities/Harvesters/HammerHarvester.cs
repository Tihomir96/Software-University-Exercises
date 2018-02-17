using System.Runtime.InteropServices;
using System.Text;

public class HammerHarvester : Harvester
{
    //UPON INITIALIZATION, increases its oreOutput by 200 %, and increases its energyRequirement by 100 %.
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = base.OreOutput +((base.OreOutput*200)/100);
        this.EnergyRequirement = this.EnergyRequirement + ((this.EnergyRequirement*100)/100);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput:f0}");
        sb.Append($"Energy Requirement: {this.EnergyRequirement:f0}");
        return sb.ToString().Trim();
    }
}

