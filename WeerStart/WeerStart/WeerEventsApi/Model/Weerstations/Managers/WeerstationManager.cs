using WeerEventsApi.Model.Metingen;
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
                repository.doeMeting(weerstation);
            }
        }

        public IEnumerable<Meting> GeefMetingen()
        {
            List<Weerstation> weerstations = repository.GeefWeerstations().ToList();
            List<Meting> metingen = new List<Meting>();
            foreach (var weerstation in weerstations)
            {
                foreach(var meting in weerstation.geefMetingen())
                {
                    metingen.Add(meting);
                }
            }
            return metingen;
        }
    }
}
