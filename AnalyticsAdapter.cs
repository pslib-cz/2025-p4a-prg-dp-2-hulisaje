namespace AdapterPattern
{
    public class AnalyticsAdapter : ILogger
    {
        private readonly AnalyticsLibrary _analyticsLibrary;
        private readonly int _defaultSeverity;

        public AnalyticsAdapter(AnalyticsLibrary analyticsLibrary, int defaultSeverity = 1)
        {
            _analyticsLibrary = analyticsLibrary;
            _defaultSeverity = defaultSeverity;
        }

        public void Log(string message)
        {
            _analyticsLibrary.TrackEvent(message, _defaultSeverity);
        }
    }
}
