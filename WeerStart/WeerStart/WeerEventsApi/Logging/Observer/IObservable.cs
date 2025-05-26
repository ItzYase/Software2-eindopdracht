using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Logging.Observer
{
    public interface IObservable
    {
        void NotifyObservers(Meting meting);
    }
}
