namespace _1.Logger.Interfaces
{
    public interface ILogger
    {
        void Error(string date , string msg);
        void Info(string date, string msg);
        void Fatal(string date, string msg);
        void Critical(string date, string msg);
        void Warning(string date, string msg);


    }
}
