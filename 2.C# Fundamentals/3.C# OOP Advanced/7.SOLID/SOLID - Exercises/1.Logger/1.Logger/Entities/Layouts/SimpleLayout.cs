using _1.Logger.Interfaces;

namespace _1.Logger.Entities.Layouts
{
    public class SimpleLayout:ILayout
    {
        public string FormatMessage(string date, string reportLevel ,string msg)
        {
            return $"{date} - {reportLevel} - {msg}";
        }
    }
}
