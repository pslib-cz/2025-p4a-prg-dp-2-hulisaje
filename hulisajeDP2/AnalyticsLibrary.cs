using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP2
{
    public class AnalyticsLibrary
    {
        public void TrackEvent(string eventName, int severity)
        {
            Console.WriteLine($"[ANALYTICS] Event: {eventName}, Severity: {severity}");
        }
    }
}
