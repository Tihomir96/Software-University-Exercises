
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;

public class DraftManager
{
    private List<SolarProvider> solarProviders;
    private List<PressureProvider> pressureProviders;
    private List<HammerHarvester> hammerHarvesters;
    private List<SonicHarvester> sonicHarvesters;

    private double totalStoredEnergy;
    private double totalStoredMinedOre;
    private static string workingMode;

    public DraftManager()
    {
        this.solarProviders=new List<SolarProvider>();
        this.pressureProviders=new List<PressureProvider>();
        this.hammerHarvesters = new List<HammerHarvester>();
        this.sonicHarvesters = new List<SonicHarvester>();
        workingMode = "Full";
    }
    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyReq = double.Parse(arguments[3]);
        if (type == "Sonic")
        {

            int sonicFactor = int.Parse(arguments[4]);
            try
            {
                var sonicHarvester = new SonicHarvester(id,oreOutput,energyReq,sonicFactor);
                this.sonicHarvesters.Add(sonicHarvester);
            }
            catch (Exception e)
            {
                return $"Harvester is not registered, because of it's {e.Message}";                
            }
        return $"Successfully registered Sonic Harvester - {id}";
        }
        else
        {
            try
            {
                var hammerHarvester = new HammerHarvester(id,oreOutput,energyReq);
                this.hammerHarvesters.Add(hammerHarvester);
            }
            catch (Exception e)
            {
                return$"Harvester is not registered, because of it's {e.Message}";
            }
            return $"Successfully registered Hammer Harvester - {id}";
        }


    }
    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        if (type == "Solar")
        {
            try
            {
                var solarProvider = new SolarProvider(id,energyOutput);
                this.solarProviders.Add(solarProvider);
            }
            catch (Exception e)
            {
                return $"Provider is not registered, because of it's {e.Message}";                
            }
            return $"Successfully registered Solar Provider - {id}";
        }
        else
        {
            try
            {
                var pressureProvider= new PressureProvider(id,energyOutput);
                this.pressureProviders.Add(pressureProvider);
            }
            catch (Exception e)
            {
                return $"Provider is not registered, because of it's {e.Message}";
            }
            return $"Successfully registered Pressure Provider - {id}";
        }

    }
    public string Day()
    {
        var energyProvidedCalc = this.pressureProviders.Sum(x => x.EnergyOutput) + this.solarProviders.Sum(x => x.EnergyOutput);
        totalStoredEnergy += energyProvidedCalc;
        double totalOreMinedForDay = 0;
        var neededEnergy = this.sonicHarvesters.Sum(x => x.EnergyRequirement) +
                           this.hammerHarvesters.Sum(x => x.EnergyRequirement);
        if (totalStoredEnergy >= neededEnergy)
        {
            if (workingMode == "Full")
            {
                foreach (var harvester in this.sonicHarvesters)
                {
                    totalStoredEnergy -= harvester.EnergyRequirement;
                    totalStoredMinedOre += harvester.OreOutput;
                    totalOreMinedForDay += harvester.OreOutput;
                }
                foreach (var harvester in hammerHarvesters)
                {
                    totalStoredEnergy -= harvester.EnergyRequirement;
                    totalStoredMinedOre += harvester.OreOutput;
                    totalOreMinedForDay += harvester.OreOutput;
                }
            }
            else if (workingMode == "Half")
            {
                foreach (var harvester in sonicHarvesters)
                {
                    totalStoredEnergy -= (harvester.EnergyRequirement - (harvester.EnergyRequirement * 60) / 100);
                    totalStoredMinedOre += (harvester.OreOutput-(harvester.OreOutput*50)/100);
                    totalOreMinedForDay += (harvester.OreOutput - (harvester.OreOutput * 50) / 100);
                }
                foreach (var harvester in hammerHarvesters)
                {
                    totalStoredEnergy -= (harvester.EnergyRequirement - (harvester.EnergyRequirement * 60) / 100);
                    totalStoredMinedOre += (harvester.OreOutput - (harvester.OreOutput * 50) / 100);
                    totalOreMinedForDay += (harvester.OreOutput - (harvester.OreOutput * 50) / 100);
                }
            }
            else if(workingMode =="Energy")
            {
                //Do nothing
            }
            var sb = new StringBuilder();
            sb.AppendLine($"A day has passed.");
            sb.AppendLine($"Energy Provided: {energyProvidedCalc:f0}");
            sb.Append($"Plumbus Ore Mined: {totalOreMinedForDay:f0}");
            return sb.ToString().Trim();
        }
        var sb2 = new StringBuilder();
        sb2.AppendLine($"A day has passed.");
        sb2.AppendLine($"Energy Provided: {energyProvidedCalc:f0}");
        sb2.Append($"Plumbus Ore Mined: 0");
        return sb2.ToString().Trim();

    }
    public string Mode(List<string> arguments)
    {
        if (arguments[0] == "Half")
        {
            workingMode = "Half";
        }
        else if (arguments[0] == "Energy")
        {
            workingMode = "Energy";
        }
        else
        {
            workingMode = "Full";
        }
        return $"Successfully changed working mode to {workingMode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        foreach (var harvester in hammerHarvesters)
        {
            if (harvester.Id== id)
            {
                return harvester.ToString().Trim();
            }
        }
        foreach (var harvester in sonicHarvesters)
        {
            if (harvester.Id == id)
            {
                return harvester.ToString().Trim();
            }
        }
        foreach (var provider in pressureProviders)
        {
            if (provider.Id == id)
            {
                return provider.ToString().Trim();
            }
        }
        foreach (var provider in solarProviders)
        {
            if (provider.Id == id)
            {
                return provider.ToString().Trim();
            }
        }
        return $"No element found with id - {id}";
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy:f0}");
        sb.Append($"Total Mined Plumbus Ore: {this.totalStoredMinedOre:f0}");
        return sb.ToString().Trim();
    }
}

