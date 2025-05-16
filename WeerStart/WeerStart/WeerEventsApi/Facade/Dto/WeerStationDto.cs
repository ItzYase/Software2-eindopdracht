using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Facade.Dto;

public class WeerStationDto
{
    public required Stad stad { get; set; }
    public required List<Meting> meting { get; set; }
}