using WeerEventsApi.Logging;
using WeerEventsApi.Model.Metingen;

public class MetingLogger : IMetingLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void Update(Meting meting)
    {
        string message = $"{meting.Tijdstip}: {meting.Waarde} {meting.Eenheid}";
        Log(message);
    }
}