using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerberichts.Proxy
{
    public interface IWeerberichtProxy
    {
        public Weerbericht GeefWeerbericht(IEnumerable<Meting> metings);
    }
}
