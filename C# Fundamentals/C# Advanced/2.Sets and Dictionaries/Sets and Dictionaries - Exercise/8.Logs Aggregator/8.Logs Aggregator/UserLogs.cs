using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Aggregator
{
    class UserLogs
    {
        public HashSet<string> UserIp { get; set; }
        public long Duration { get; set; }

    }
}
