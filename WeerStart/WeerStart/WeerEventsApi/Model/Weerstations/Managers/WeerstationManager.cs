using WeerEventsApi.Model.Weerstations.Repositories;

namespace WeerEventsApi.Model.Weerstations.Managers
{
    public class WeerstationManager(IWeerstationRepository repository) : IWeerstationManager
    {
        public IEnumerable<Weerstation> GeefWeerstations()
        {
            return repository.GeefWeerstations();
        }

        public void DoeMeting()
        {
            List<Weerstation> weerstations = repository.GeefWeerstations().ToList();
            foreach (var weerstation in weerstations)
            {
                repository.VoegMetingToe(weerstation, weerstation.doeMeting());
            }
        }
    }
}
