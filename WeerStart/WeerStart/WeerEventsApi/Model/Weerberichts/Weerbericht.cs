namespace WeerEventsApi.Model.Weerberichts
{
    public class Weerbericht
    {
        public Weerbericht(DateTime dateTime, string inhoud)
        {
            DateTime = dateTime;
            Inhoud = inhoud;
        }

        public DateTime DateTime { get; set; }
        public string Inhoud { get; set; }
    }
}
