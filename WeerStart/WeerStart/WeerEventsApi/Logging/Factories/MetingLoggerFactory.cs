using WeerEventsApi.Logging;

public static class MetingLoggerFactory
{
    public static IMetingLogger Create(bool decorateWithJson = false, bool decorateWithXml = false)
    {
        IMetingLogger logger = new MetingLogger();

        if (decorateWithJson)
        {
            logger = new JsonMetingLogger(logger);
        }

        if (decorateWithXml)
        {
            logger = new XmlMetingLogger(logger);
        }

        return logger;
    }
}