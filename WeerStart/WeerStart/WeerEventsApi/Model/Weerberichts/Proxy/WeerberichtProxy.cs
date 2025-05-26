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
            _cachedWeerbericht = service.GeefWeerbericht(metingen);
            _laatsteGenereerTijd = DateTime.Now;
        }
        return _cachedWeerbericht;
    }
}