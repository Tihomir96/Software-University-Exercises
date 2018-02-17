using System;
using System.Globalization;

namespace _1.Event_Impl
{
    public class NameChangeEventArgs:EventArgs
    {
        public NameChangeEventArgs(string name)
        {
            this.Name = name;
            
        }
        public string Name { get; private set; }

        
    }
}
