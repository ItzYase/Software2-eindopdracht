using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerberichts.Services
{
    public interface IService
    {
        public Weerbericht GeefWeerbericht(IEnumerable<Meting> metingen);
    }
}
