using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Event
    {
        public string EventName { get; set; }
        public HashSet<string> EventParticipants { get; set; } = new HashSet<string>();
    }
}
