using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Engine
{
    private DraftManager draftManager;
    public void Run()
    {
        this.draftManager = new DraftManager();
        var input = Console.ReadLine();
        while (input!="Shutdown")
        {
            var inputTokens = input.Split(' ');
            ExecuteCommand(inputTokens);
            input = Console.ReadLine();
        }
        Console.WriteLine(draftManager.ShutDown());
    }

    public void ExecuteCommand(string[]cmd)
    {        
        var cmdList = cmd.ToList();
        cmdList.RemoveAt(0);
        switch (cmd[0])
        {
            case "RegisterHarvester":                
                Console.WriteLine(draftManager.RegisterHarvester(cmdList));                
                break;
            case "RegisterProvider":
                Console.WriteLine(draftManager.RegisterProvider(cmdList));
                break;
            case "Day":
                Console.WriteLine(draftManager.Day());
                break;
            case "Mode":
                Console.WriteLine(draftManager.Mode(cmdList));
                break;
            case"Check":
                Console.WriteLine(draftManager.Check(cmdList));
                break;                
        }   
    }
}


