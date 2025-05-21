using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Weerstations
{
    public class NeerslagStation : Weerstation
    {
        public NeerslagStation(Stad stad, List<Meting> metingen)
        {
            this.stad = stad;
            this.metingen = metingen;
        }

        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }
    
        public void doeMeting()
        {
            Random random = new Random();
            double neerslag = random.Next(0, 20) + random.NextDouble();
            Meting meting = new(DateTime.Now, neerslag, Eenheid.mmPh);
            metingen.Add(meting);
        }

        public List<Meting> geefMetingen()
        {
            return metingen;
        }

        IEnumerable<Meting> Weerstation.geefMetingen()
        {
            return metingen;
        }
    }
}
