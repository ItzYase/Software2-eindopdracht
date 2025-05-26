using WeerEventsApi.Logging;
using WeerEventsApi.Model.Metingen;

public class XmlMetingLogger : IMetingLogger
{
    private readonly IMetingLogger _innerLogger;
    private readonly string _xmlLogFile = "Logs\\log.xml";

    public XmlMetingLogger(IMetingLogger innerLogger)
    {
        _innerLogger = innerLogger;
    }

    public void Log(string message)
    {
        _innerLogger.Log(message);
    }

    public void Update(Meting meting)
    {
        // Eerst de onderliggende logger aanroepen
        _innerLogger.Update(meting);

        string xmlEntry =
            $"<Meting>\n" +
            $"  <Moment>{meting.Tijdstip}</Moment>\n" +
            $"  <Waarde>{meting.Waarde}</Waarde>\n" +
            $"  <Eenheid>{meting.Eenheid}</Eenheid>\n" +
            $"</Meting>\n";

        File.AppendAllText(_xmlLogFile, xmlEntry);
    }
}