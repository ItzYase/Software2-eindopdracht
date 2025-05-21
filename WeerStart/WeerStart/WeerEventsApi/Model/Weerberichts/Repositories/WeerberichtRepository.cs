using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Weerberichts.Proxy;

namespace WeerEventsApi.Model.Weerberichts.Repositories
{
    public class WeerberichtRepository(IWeerberichtProxy weerberichtProxy) : IWeerberichtRepository
    {
        public Weerbericht GeefWeerbericht(IEnumerable<Meting> metings)
        {
            return weerberichtProxy.GeefWeerbericht(metings);
        }
    }
}
