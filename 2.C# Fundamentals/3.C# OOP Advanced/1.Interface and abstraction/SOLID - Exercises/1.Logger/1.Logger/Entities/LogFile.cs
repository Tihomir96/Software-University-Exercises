using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _1.Logger.Entities
{
    public class LogFile
    {
        private const string FileName = "log.txt";
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string formatMsg)
        {
            this.sb.AppendLine(formatMsg);
            File.AppendAllText(FileName,formatMsg+Environment.NewLine);
            this.Size = this.GetLettersSum(formatMsg);
        }

        private int GetLettersSum(string formatMsg)
        {
            return formatMsg.Where(x => char.IsLetter(x)).Sum(x => x);
        }
    }
}
