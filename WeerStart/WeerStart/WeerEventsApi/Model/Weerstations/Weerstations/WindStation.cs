using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Weerstations
{
    public class WindStation : Weerstation
    {
        public WindStation(Stad stad, List<Meting> meting) : base(stad, meting)
        {
        }
    }
}
