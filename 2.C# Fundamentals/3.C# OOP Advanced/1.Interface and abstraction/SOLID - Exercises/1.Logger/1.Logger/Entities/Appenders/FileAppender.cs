using System.Text;
using _1.Logger.Entities.Layouts;
using _1.Logger.Enums;
using _1.Logger.Interfaces;

namespace _1.Logger.Entities.Appenders
{
    public class FileAppender:IAppender
    {
      
        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
            this.File = new LogFile();
        }

        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public LogFile File { get; set; }

        public void Append(string date, string reportLevel, string msg)
        {
            var formatMsg = this.Layout.FormatMessage(date, reportLevel, msg);
            this.File.Write(formatMsg);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            return sb.AppendLine($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ").Append($"Report level: {this.ReportLevel}, ")
                .Append($"File Size: {this.File.Size}").ToString();
        }
    }
}
