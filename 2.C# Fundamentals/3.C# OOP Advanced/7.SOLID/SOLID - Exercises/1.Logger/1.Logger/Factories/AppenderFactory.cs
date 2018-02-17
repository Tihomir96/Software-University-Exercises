using System;
using System.Linq;
using System.Reflection;
using _1.Logger.Interfaces;

namespace _1.Logger.Factories
{
    public class AppenderFactory
    {
        public static IAppender GetAppender(string appenderType,ILayout layout)
        {
            Type typeofAppender = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == appenderType);
            return (IAppender)Activator.CreateInstance(typeofAppender,layout);
        }
    }
}
