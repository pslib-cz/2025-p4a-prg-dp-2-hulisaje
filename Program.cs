namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Adapter Pattern Demo ===\n");

            var analyticsLibrary = new AnalyticsLibrary();

            ILogger logger = new AnalyticsAdapter(analyticsLibrary, defaultSeverity: 2);

            Console.WriteLine("Volání přes ILogger.Log() (existující kód aplikace):");
            logger.Log("Uživatel se přihlásil");
            logger.Log("Načtena stránka produktu");
            logger.Log("Objednávka dokončena");

            Console.WriteLine("\n=== Konec demo ===");
        }
    }
}
