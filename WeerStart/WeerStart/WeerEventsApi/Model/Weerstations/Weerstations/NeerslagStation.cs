using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Weerstations
{
    public class NeerslagStation : Weerstation
    {
        public NeerslagStation(Stad stad, List<Meting> meting) : base(stad, meting)
        {
        }
    }
}
