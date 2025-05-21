namespace WeerEventsApi.Model.Weerberichts.Proxy
{
    public class WeerberichtProxy : IWeerberichtProxy
    {
        private Weerbericht weerbericht { get; set; }
        private DateTime laatsteCacheTIjd;
        public Weerbericht GeefWeerbericht()
        {
            if (weerbericht != null || (DateTime.Now - laatsteCacheTIjd).TotalMinutes < 1)
            {
                return weerbericht;
            }
            else
            {
                return weerbericht = new Weerbericht
                {
                    DateTime = DateTime.Now,
                    Inhoud = 20.0
                };
            }
        }
    }
}
