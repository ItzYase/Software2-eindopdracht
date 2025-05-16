using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerberichts;
using WeerEventsApi.Model.Metingen;
using System.Collections.Generic;

namespace WeerEventsApi.Model.Weerstations
{
    public abstract class Weerstation
    {
        public Stad stad { get; set; }
        public List<Meting> meting { get; set; }
    }
}
