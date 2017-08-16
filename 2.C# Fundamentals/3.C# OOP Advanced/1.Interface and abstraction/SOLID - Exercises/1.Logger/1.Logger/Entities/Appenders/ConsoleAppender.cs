using System;
using System.Text;
using _1.Logger.Enums;
using _1.Logger.Interfaces;

namespace _1.Logger.Entities.Appenders
{
    public class ConsoleAppender:IAppender
    {
      

        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }

        public void Append(string date, string reportLevel, string msg)
        {
            string formattedMsg = this.Layout.FormatMessage(date, reportLevel, msg);
            Console.WriteLine(formattedMsg);

        }
    }
}
