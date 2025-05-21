using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerberichts;
using WeerEventsApi.Model.Metingen;
using System.Collections.Generic;

namespace WeerEventsApi.Model.Weerstations
{
    public interface Weerstation
    {
        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }
        public void doeMeting();
        public IEnumerable<Meting> geefMetingen();

    }
}
