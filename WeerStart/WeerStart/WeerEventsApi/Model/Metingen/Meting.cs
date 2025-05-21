using WeerEventsApi.Model.Weerstations.Enumiraties;

namespace WeerEventsApi.Model.Metingen
{ 

    public class Meting
    {
        public Meting(DateTime tijdstip, double waarde, Eenheid eenheid)
        {
            Tijdstip = tijdstip;
            Waarde = waarde;
            Eenheid = eenheid;
        }

        public DateTime Tijdstip { get; set; }
        public double Waarde { get; set; }
        public Eenheid Eenheid { get; set; }
    }
}
