
using WeerEventsApi.Model.Metingen.Repositories;

namespace WeerEventsApi.Model.Metingen.Managers
{
    public class MetingManager(IMetingRepository repository) : IMetingManager
    {

        public void DoeMetingen()
        {
            return
        }

        public IEnumerable<Meting> GeefMetingen()
        {
            return repository.GeefMetingen();
        }
    }
}
