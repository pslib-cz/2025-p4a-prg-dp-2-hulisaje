namespace AdapterPattern
{
    public class AnalyticsLibrary
    {
        public void TrackEvent(string eventName, int severity)
        {
            Console.WriteLine($"[Analytics] Event: '{eventName}' | Severity: {severity}");
        }
    }
}
