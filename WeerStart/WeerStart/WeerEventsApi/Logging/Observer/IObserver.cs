using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Logging.Observer
{
    public interface IObserver
    {
        void Update(Meting meting);
    }
}
