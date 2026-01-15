using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP2
{
    public class AnalyticsLoggingState : ILoggingState
    {
        private readonly AnalyticsLibrary _analytics;

        public AnalyticsLoggingState()
        {
            _analytics = new AnalyticsLibrary();
        }

        public void Log(string message)
        {
            int severity = CalculateSeverity(message);
            _analytics.TrackEvent(message, severity);
        }

        private int CalculateSeverity(string message)
        {
            if (message.Contains("ERROR"))
                return 3;
            if (message.Contains("WARN"))
                return 2;
            return 1;
        }
    }
}
