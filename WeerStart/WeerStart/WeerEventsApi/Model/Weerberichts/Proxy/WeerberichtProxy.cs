using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Weerberichts;
using WeerEventsApi.Model.Weerberichts.Proxy;
using WeerEventsApi.Model.Weerberichts.Services;
public class WeerberichtProxy(IService service) : IWeerberichtProxy
{
    private Weerbericht _cachedWeerbericht;
    private DateTime _laatsteGenereerTijd;

    public Weerbericht GeefWeerbericht(IEnumerable<Meting> metingen)
    {
        if (_cachedWeerbericht == null || (DateTime.Now - _laatsteGenereerTijd).TotalMinutes > 1)
        {
            service.GeefWeerbericht(metingen);
        }
        return _cachedWeerbericht;
    }
}