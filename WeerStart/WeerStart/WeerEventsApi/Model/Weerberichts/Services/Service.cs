using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerberichts.Services
{
    public class Service : IService
    {
        public Weerbericht GeefWeerbericht(IEnumerable<Meting> metingen)
        {
            Thread.Sleep(5000);
            Random random = new Random();
            bool isGoedWeer = random.Next(2) == 0;
            string weerType = isGoedWeer ? "goed" : "slecht";
            string inhoud = $"Op basis van {metingen.Count()} metingen en mijn diepzinnig computermodel kan ik zeggen dat er kans is op {weerType} weer.";
            return new Weerbericht(DateTime.Now, inhoud);
        }
    }
}