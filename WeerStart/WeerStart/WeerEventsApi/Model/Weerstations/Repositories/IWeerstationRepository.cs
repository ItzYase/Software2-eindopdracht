using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerstations.Repositories
{
    public interface IWeerstationRepository
    {
        public IEnumerable<Weerstation> GeefWeerstations();
        public void doeMeting(Weerstation weerstation);
    }
}
