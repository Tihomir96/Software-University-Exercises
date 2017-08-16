namespace _1.Logger.Interfaces
{
    public interface  ILayout
    {
        
        string FormatMessage(string date, string reportLevel,string msg);
    }
}
