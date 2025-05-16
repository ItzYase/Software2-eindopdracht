using System;
using System.Diagnostics.Metrics;
using WeerEventsApi.Model.Metingen;
using WeerEventsApi.Model.Steden;
using WeerEventsApi.Model.Steden.Managers;
using WeerEventsApi.Model.Steden.Repositories;
using WeerEventsApi.Model.Weerstations;
namespace WeerEventsApi.Model.Weerstations.Data
{
    public static class Factory
    {
        private static StadManager stadManager = new StadManager(new StadRepository());        
        public static IEnumerable<Weerstation> MaakWeerstations()
        {
            Random rnd = new Random();
            IEnumerable<Stad> steden = stadManager.GeefSteden();
            IEnumerable<Weerstation> weerstations;
            int randomStation = 0;
            int randomStad = 0;
            for (int i = 0; i < 12; i++)
            {
                randomStad = rnd.Next(0, 3);
                randomStation = rnd.Next(0, 4);
                switch (randomStation)
                {
                    case 0:
                        weerstations.Add(new TemperatuurStation(steden[randomStad], new List<Meting>()));
                        break;

                    case 1:
                        weerstations.Add(new LuchtdrukStation(steden[randomStad], new List<Meting>()));
                        break;

                    case 2:
                        weerstations.Add(new WindStation(steden[randomStad], new List<Meting>()));
                        break;
                    case 3:
                        weerstations.Add(new NeerslagStation(steden[randomStad], new List<Meting>()));
                        break;
                }
            }
            return weerstations;
        }
    }
}
