using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerberichts;
using WeerEventsApi.Model.Metingen;
using System.Collections.Generic;
using WeerEventsApi.Logging.Observer;

namespace WeerEventsApi.Model.Weerstations
{
    public interface Weerstation : IObservable
    {
        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }
        public void doeMeting();
        public IEnumerable<Meting> geefMetingen();

    }
}
