using System.Text.Json;
using WeerEventsApi.Logging;
using WeerEventsApi.Model.Metingen;

public class JsonMetingLogger : IMetingLogger
{
    private readonly IMetingLogger _innerLogger;
    private readonly string _jsonLogFile = "Logs\\log.json";

    public JsonMetingLogger(IMetingLogger innerLogger)
    {
        _innerLogger = innerLogger;
    }

    public void Log(string message)
    {
        _innerLogger.Log(message);
    }

    public void Update(Meting meting)
    {
        _innerLogger.Update(meting);
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonEntry = JsonSerializer.Serialize(meting, options);

        System.IO.File.AppendAllText(_jsonLogFile, jsonEntry + Environment.NewLine);
    }
}