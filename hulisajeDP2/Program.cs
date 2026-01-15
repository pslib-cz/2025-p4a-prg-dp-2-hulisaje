using hulisajeDP2;

ILogger logger = new LoggerContext(new LegacyLoggingState());

logger.Log("Application started");
logger.Log("WARN: Low memory");

((LoggerContext)logger).SetState(new AnalyticsLoggingState());

logger.Log("User logged in");
logger.Log("ERROR: Database connection failed");

Console.ReadLine();