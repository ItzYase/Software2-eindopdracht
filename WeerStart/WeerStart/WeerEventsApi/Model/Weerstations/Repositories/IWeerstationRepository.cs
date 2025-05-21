using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerstations.Repositories
{
    public interface IWeerstationRepository
    {
        public IEnumerable<Weerstation> GeefWeerstations();
        void VoegMetingToe(Weerstation weerstation, Meting meting);
    }
}
