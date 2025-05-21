using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Weerstations
{
    public class NeerslagStation : Weerstation
    {
        public Stad stad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Meting> metingen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
        public Meting doeMeting()
        {
            Random random = new Random();
            double neerslag = random.Next(0, 20) + random.NextDouble();
            Meting meting = new(DateTime.Now, neerslag, Eenheid.mmPh);
            metingen.Add(meting);
            return meting;
        }

        public List<Meting> geefMetingen()
        {
            return metingen;
        }
    }
}
