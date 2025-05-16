using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Steden.Repositories;

namespace WeerEventsApi.Model.Steden.Managers;

public class StadManager(IStadRepository repository) : IStadManager
{
    public IEnumerable<Stad> GeefSteden()
    {
        return repository.GetSteden();
    }
}