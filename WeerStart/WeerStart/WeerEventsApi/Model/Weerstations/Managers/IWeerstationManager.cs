namespace WeerEventsApi.Model.Weerstations.Managers
{
    public interface IWeerstationManager 
    {
        public IEnumerable<Weerstation> GeefWeerstations();
        public void DoeMeting();
    }
}
