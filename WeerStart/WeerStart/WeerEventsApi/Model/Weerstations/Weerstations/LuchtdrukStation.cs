using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Weerstations
{
    public class LuchtdrukStation : Weerstation
    {
        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }

        public Meting doeMeting()
        {
            Random random = new Random();
            double luchtdruk = random.Next(965, 1050) + random.NextDouble();
            Meting meting = new(DateTime.Now, luchtdruk, Eenheid.hPa);
            metingen.Add(meting);
            return meting;
        }

        public List<Meting> geefMetingen()
        {
            return metingen;
        }
    }
}
