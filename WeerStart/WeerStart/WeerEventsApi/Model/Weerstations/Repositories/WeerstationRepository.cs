using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Weerstations.Data;

namespace WeerEventsApi.Model.Weerstations.Repositories
{
    public class WeerstationRepository : IWeerstationRepository
    {
        private IEnumerable<Weerstation> _weerstations = Factory.MaakWeerstations();
        public IEnumerable<Weerstation> GeefWeerstations()
        {
            return _weerstations;
        }

        public void VoegMetingToe(Weerstation weerstation, Meting meting)
        {
           _weerstations.Where(w => w != weerstation).First().metingen.Add(meting);
        }
    }
}
