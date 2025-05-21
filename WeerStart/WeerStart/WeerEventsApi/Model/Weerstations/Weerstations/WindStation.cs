using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Weerstations
{
    public class WindStation : Weerstation
    {
        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }

        public Meting doeMeting()
        {
            Random random = new Random();
            double windSnelheid = random.Next(0, 150) + random.NextDouble();
            Meting meting = new(DateTime.Now, windSnelheid, Eenheid.kmh);
            metingen.Add(meting);
            return meting;
        }

        public List<Meting> geefMetingen()
        {
            return metingen;
        }
    }
}
