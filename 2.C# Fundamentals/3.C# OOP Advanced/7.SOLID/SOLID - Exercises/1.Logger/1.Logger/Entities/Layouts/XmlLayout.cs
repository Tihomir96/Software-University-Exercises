using System.Text;
using _1.Logger.Interfaces;

namespace _1.Logger.Entities.Layouts
{
    public class XmlLayout:ILayout
    {
        public string FormatMessage(string date, string reportLevel, string msg)
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendLine($"<log>")
                .AppendLine($"    <date>{date}</date>")
                .AppendLine($"    <level>{reportLevel}</level>")
                .AppendLine($"    <message>{msg}</message>")
                .Append($"</log").ToString();
        }
    }
}
