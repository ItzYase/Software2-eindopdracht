using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Steden.Managers;

public interface IStadManager
{
    IEnumerable<Stad> GeefSteden();
}