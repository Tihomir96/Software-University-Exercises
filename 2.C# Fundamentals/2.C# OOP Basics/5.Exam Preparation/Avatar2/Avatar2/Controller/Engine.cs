using System;
using System.Linq;

public class Engine
{
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        var command = string.Empty;
        while ((command = Console.ReadLine()) != "Quit")
        {
            var cmdArgs = command.Split(' ');
            ExecuteCommand(cmdArgs);
        }
        Console.WriteLine(nationsBuilder.GetWarsRecord());
    }

    public void ExecuteCommand(string[] cmdArgs)
    {
        switch (cmdArgs[0])
        {
            case "Bender":
                nationsBuilder.AssignBender(cmdArgs.ToList());
                break;
            case "War":
                nationsBuilder.IssueWar(cmdArgs[1]);
                break;
            case "Status":
                Console.WriteLine(nationsBuilder.GetStatus(cmdArgs[1]));
                break;
            case "Monument":
                nationsBuilder.AssignMonument(cmdArgs.ToList());
                break;
        }
    }
}

