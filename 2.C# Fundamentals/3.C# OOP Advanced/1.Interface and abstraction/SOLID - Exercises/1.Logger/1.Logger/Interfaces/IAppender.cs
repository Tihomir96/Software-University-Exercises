using _1.Logger.Enums;

namespace _1.Logger.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ReportLevel ReportLevel { get; set; }
        void Append(string date,string reportLevel, string msg);
        
    }
}
