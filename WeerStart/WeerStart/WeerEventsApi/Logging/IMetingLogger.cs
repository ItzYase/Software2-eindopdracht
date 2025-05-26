using WeerEventsApi.Logging.Observer;

namespace WeerEventsApi.Logging;

public interface IMetingLogger : IObserver
{
    void Log(string message);
}