using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;

namespace WeerEventsApi.Model.Weerstations
{
    public class LuchtdrukStation : Weerstation
    {
        public LuchtdrukStation(Stad stad, List<Meting> meting) : base(stad, meting)
        {
        }
    }
}
