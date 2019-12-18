using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab31EventLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog.WriteEntry("Application", "Hey we are taking over your computer", EventLogEntryType.Error, 5001, 1239);
        }
    }
}
