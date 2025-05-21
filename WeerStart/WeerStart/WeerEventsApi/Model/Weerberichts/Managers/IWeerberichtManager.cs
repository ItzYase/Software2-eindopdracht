using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerberichts.Managers
{
    public interface IWeerberichtManager
    {
       Weerbericht GeefWeerbericht(IEnumerable<Meting> metings);
    }
}
