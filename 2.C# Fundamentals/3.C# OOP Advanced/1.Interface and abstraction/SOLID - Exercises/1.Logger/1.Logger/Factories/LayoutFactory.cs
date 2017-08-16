using System;
using System.Linq;
using System.Reflection;
using _1.Logger.Interfaces;

namespace _1.Logger.Factories
{
    public class LayoutFactory
    {
        public static ILayout GetInstance(string typeLayout)
        {
            Type layoutType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == typeLayout);
            return (ILayout) Activator.CreateInstance(layoutType);
        }
    }
}
