using WeerEventsApi.Model.Weerberichts.Repositories;

namespace WeerEventsApi.Model.Weerberichts.Managers
{
    public class WeerberichtManager(IWeerberichtRepository repository) : IWeerberichtManager
    {
        public IEnumerable<Weerbericht> GeefWeerberichten()
        {
            Thread.Sleep(5000);
            return repository.GeefWeerberichten();
        }
    }
}
