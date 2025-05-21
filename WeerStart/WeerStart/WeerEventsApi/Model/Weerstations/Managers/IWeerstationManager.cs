using WeerEventsApi.Model.Metingen;

namespace WeerEventsApi.Model.Weerstations.Managers
{
    public interface IWeerstationManager 
    {
        public IEnumerable<Weerstation> GeefWeerstations();
        public void DoeMeting();
        public IEnumerable<Meting> GeefMetingen();
    }
}
