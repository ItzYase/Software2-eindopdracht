using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Weerstations
{
    public class TemperatuurStation : Weerstation
    {
        public TemperatuurStation(Stad stad, List<Meting> metingen)
        {
            this.stad = stad;
            this.metingen = metingen;
        }

        public Stad stad { get; set; }
        public List<Meting> metingen { get; set; }

        public void doeMeting()
        {
            Random random = new Random();
            double temperatuur = random.Next(-10, 35) + random.NextDouble();
            Meting meting = new(DateTime.Now, temperatuur, Eenheid.Celsius);
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
