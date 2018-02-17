
    using System.Text;

public class SonicHarvester:Harvester
    {
        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
        {
            this.sonicFactor = sonicFactor;
            this.EnergyRequirement = this.EnergyRequirement/this.sonicFactor;
        }

        private int sonicFactor;
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sonic Harvester - {this.Id}");
            sb.AppendLine($"Ore Output: {this.OreOutput:f0}");
            sb.Append($"Energy Requirement: {this.EnergyRequirement:f0}");
            return sb.ToString().Trim();
        }
}

