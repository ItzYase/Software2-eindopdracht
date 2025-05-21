using System.Text.Json;
using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Steden.Repositories;

public class StadRepository : IStadRepository
{
    public IEnumerable<Stad> GetSteden()
    {
        return JsonSerializer.Deserialize<List<Stad>>(File.ReadAllText("Model/Steden/Data/steden.json"))!;
    }
}