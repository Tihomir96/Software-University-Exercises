using System;
using System.Globalization;
using System.Reflection;
using _1.Logger.Enums;
using _1.Logger.Factories;
using _1.Logger.Interfaces;

namespace _1.Logger
{
    public class StartUp
    {
        public static void Main()
        {
            var appendersCount = int.Parse(Console.ReadLine());
            IAppender[] appenders = new IAppender[appendersCount];

            for (int i = 0; i < appendersCount; i++)
            {
                var appenderInfo = Console.ReadLine().Split();
                ILayout currentLayout = LayoutFactory.GetInstance(appenderInfo[1]);
                var currAppender = AppenderFactory.GetAppender(appenderInfo[0], currentLayout);
                if (appenderInfo.Length > 2)
                {
                    string enumName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(appenderInfo[2].ToLower());
                    currAppender.ReportLevel = (ReportLevel) Enum.Parse(typeof(ReportLevel), enumName);
                }
                appenders[i] = currAppender;
            }
            var myLogger = new Entities.Logger(appenders);
            string input;

            while ((input=Console.ReadLine())!="END")
            {
                var tokens = input.Split('|');
                var methodName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tokens[0].ToLower());
                MethodInfo currentMethod = typeof(Entities.Logger).GetMethod(methodName);
                currentMethod.Invoke(myLogger, new object[] {tokens[1],tokens[2]});
            }
            Console.WriteLine(myLogger);
        }
    }
}
