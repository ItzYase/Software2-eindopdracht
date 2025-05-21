using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Weerberichts.Repositories;

namespace WeerEventsApi.Model.Weerberichts.Managers
{
    public class WeerberichtManager(IWeerberichtRepository repository) : IWeerberichtManager
    {
        public Weerbericht GeefWeerbericht(IEnumerable<Meting> metings)
        {
            Thread.Sleep(5000);
            return repository.GeefWeerbericht(metings);
        }
    }
}
