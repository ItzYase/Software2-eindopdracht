using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerberichts.Repositories
{
    public interface IWeerberichtRepository
    {
        Weerbericht GeefWeerbericht(IEnumerable<Meting> metings);
    }
}
