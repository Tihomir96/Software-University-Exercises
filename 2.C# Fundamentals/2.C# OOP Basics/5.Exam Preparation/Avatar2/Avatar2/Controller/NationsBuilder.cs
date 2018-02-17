using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class NationsBuilder
{
    public NationsBuilder()
    {
        this.warHistory = new List<string>();
    }
    private Nation nations = new Nation();
    public void AssignBender(List<string> benderArgs)
    {
        switch (benderArgs[1])
        {
            case "Fire":
                var fireBender = new FireBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                nations.FireNation.Add(fireBender);
                break;
            case "Air":
                var airBender = new AirBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                nations.AirNation.Add(airBender);
                break;
            case "Water":
                var waterBender = new WaterBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                nations.WaterNation.Add(waterBender);
                break;
            case "Earth":
                var earthBender = new EarthBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                nations.EarthNation.Add(earthBender);
                break;

        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        switch (monumentArgs[1])
        {
            case "Fire":
                var fireMonument = new FireMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                nations.FireMonuments.Add(fireMonument);
                break;
            case "Air":
                var airMonument = new AirMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                nations.AirMonuments.Add(airMonument);
                
                break;
            case "Water":
                var waterMonument = new WaterMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                nations.WaterMonuments.Add(waterMonument);
                
                break;
            case "Earth":
                var earthMonument = new EarthMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                nations.EarthMonuments.Add(earthMonument);
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        switch (nationsType)
        {
            case "Fire":
                var sb = new StringBuilder();
                sb.AppendLine("Fire Nation");
                if (nations.FireNation.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in nations.FireNation)
                    {
                        sb.AppendLine(
                            $"###Fire Bender: {bender.Name}, Power: {bender.Power}, Heat Aggression: {bender.HeatAgression:f2}");
                    }
                }
                if (nations.FireMonuments.Count == 0)
                {
                    sb.AppendLine("Monuments: None");
                }
                else
                {
                    sb.AppendLine("Monuments:");
                    foreach (var monument in nations.FireMonuments)
                    {
                        sb.AppendLine($"###Fire Monument: {monument.Name}, Fire Affinity: {monument.FireAffinity}");
                    }
                }
                return sb.ToString().Trim();

            case "Water":
                sb = new StringBuilder();
                sb.AppendLine("Water Nation");
                if (nations.WaterNation.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in nations.WaterNation)
                    {
                        sb.AppendLine(
                            $"###Fire Bender: {bender.Name}, Power: {bender.Power}, Water Clarity: {bender.WaterClarity:f2}");
                    }
                }
                if (nations.WaterMonuments.Count == 0)
                {
                    sb.AppendLine("Monuments: None");
                }
                else
                {
                    sb.AppendLine("Monuments:");
                    foreach (var monument in nations.WaterMonuments)
                    {
                        sb.AppendLine($"###Water Monument: {monument.Name}, Water Affinity: {monument.WaterAffinity}");
                    }
                }
                return sb.ToString().Trim();
            case "Earth":
                sb = new StringBuilder();
                sb.AppendLine("Earth Nation");
                if (nations.EarthNation.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in nations.EarthNation)
                    {
                        sb.AppendLine(
                            $"###Earth Bender: {bender.Name}, Power: {bender.Power}, Ground Saturation: {bender.GroundSaturation:f2}");
                    }
                }
                if (nations.EarthMonuments.Count == 0)
                {
                    sb.AppendLine("Monuments: None");
                }
                else
                {
                    sb.AppendLine("Monuments:");
                    foreach (var monument in nations.EarthMonuments)
                    {
                        sb.AppendLine($"###Earth Monument: {monument.Name}, Earth Affinity: {monument.EarthAffinity}");
                    }
                }
                return sb.ToString().Trim();
            case "Air":
                sb = new StringBuilder();
                sb.AppendLine("Air Nation");
                if (nations.AirNation.Count == 0)
                {
                    sb.AppendLine("Benders: None");
                }
                else
                {
                    sb.AppendLine("Benders:");
                    foreach (var bender in nations.AirNation)
                    {
                        sb.AppendLine(
                            $"###Air Bender: {bender.Name}, Power: {bender.Power}, Aerial Integrity: {bender.AerialIntegrity:f2}");
                    }
                }
                if (nations.AirMonuments.Count == 0)
                {
                    sb.AppendLine("Monuments: None");
                }
                else
                {
                    sb.AppendLine("Monuments:");
                    foreach (var monument in nations.AirMonuments)
                    {
                        sb.AppendLine($"###Air Monument: {monument.Name}, Air Affinity: {monument.AirAffinity}");
                    }
                }
                return sb.ToString().Trim();
        }

        return string.Empty;
    }


    private List<string> warHistory;


    public void IssueWar(string nationsType)
    {
        this.warHistory.Add(nationsType);
        var list = new List<double>();
        double airPoints = nations.totalPowerAir();
        double earthPoints = nations.totalPowerEarth();
        double waterPoints = nations.totalPowerEarth();
        double firePoints = nations.TotalPowerFire();

        list.Add(airPoints);
        list.Add(earthPoints);
        list.Add(waterPoints);
        list.Add(firePoints);
        double result = list.Max();
        if (result == airPoints)
        {
            nations.EarthNation.Clear();
            nations.EarthMonuments.Clear();
            nations.WaterNation.Clear();
            nations.WaterMonuments.Clear();
            nations.FireNation.Clear();
            nations.FireMonuments.Clear();
        }
        else if (result == earthPoints)
        {
            nations.AirNation.Clear();
            nations.AirMonuments.Clear();
            nations.WaterNation.Clear();
            nations.WaterMonuments.Clear();
            nations.FireNation.Clear();
            nations.FireMonuments.Clear();
        }
        else if (result == waterPoints)
        {
            nations.AirNation.Clear();
            nations.AirMonuments.Clear();
            nations.EarthNation.Clear();
            nations.EarthMonuments.Clear();
            nations.FireNation.Clear();
            nations.FireMonuments.Clear();
        }
        else
        {
            nations.AirNation.Clear();
            nations.AirMonuments.Clear();
            nations.EarthNation.Clear();
            nations.EarthMonuments.Clear();
            nations.WaterNation.Clear();
            nations.WaterMonuments.Clear();
        }
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < this.warHistory.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {warHistory[i]}");
        }
        return sb.ToString().Trim();
    }

}


