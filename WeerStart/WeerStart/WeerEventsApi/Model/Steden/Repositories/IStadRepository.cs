using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Steden.Repositories;

public interface IStadRepository
{
    IEnumerable<Stad> GetSteden();
}