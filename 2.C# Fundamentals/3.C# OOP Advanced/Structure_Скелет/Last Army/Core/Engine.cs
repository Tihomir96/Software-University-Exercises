using System;
using System.Text;


public class Engine : IEngine
{
    public Engine()
    {
        this.consoleReader =new ConsoleReader();
        this.consoleWriter = new ConsoleWriter();
    }
    private IReader consoleReader;
    private IWriter consoleWriter;
    public void Run()
    {
        var input = consoleReader.ReadLine();
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = consoleReader.ReadLine();
        }

        gameController.RequestResult(result);
        consoleWriter.WriteLine(result.ToString());
    }
}

