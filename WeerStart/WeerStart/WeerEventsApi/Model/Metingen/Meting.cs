namespace WeerEventsApi.Model.Metingen
{ 

    public class Meting
    {
        public DateTime Tijdstip { get; set; }
        public double Waarde { get; set; }
        public string Eenheid { get; set; }
    }
}
