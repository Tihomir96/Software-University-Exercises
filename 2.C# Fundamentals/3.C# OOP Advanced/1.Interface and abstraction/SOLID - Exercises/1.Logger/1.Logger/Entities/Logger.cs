using System;
using System.Text;
using _1.Logger.Enums;
using _1.Logger.Interfaces;

namespace _1.Logger.Entities
{
    public class Logger:ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string date,string reportLevel, string msg)
        {
            foreach (IAppender appender in this.appenders)
            {
                ReportLevel curReportLevel = (ReportLevel) Enum.Parse(typeof(ReportLevel), reportLevel);
                if (appender.ReportLevel <= curReportLevel)
                {
                    appender.Append(date,reportLevel,msg);
                }
            }
        }
        public void Error(string date, string msg)
        {
            this.Log(date,"Error",msg);
        }

        public void Info(string date, string msg)
        {
            this.Log(date, "Info", msg);
        }

        public void Fatal(string date, string msg)
        {
            this.Log(date, "Fatal", msg);
        }

        public void Critical(string date, string msg)
        {
            this.Log(date, "Critical", msg);
        }

        public void Warning(string date, string msg)
        {
            this.Log(date, "Warning", msg);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Logger Info");
            foreach (IAppender appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
