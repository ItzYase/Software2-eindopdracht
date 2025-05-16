namespace WeerEventsApi.Model.Metingen.Managers
{
    public interface IMetingManager
    {
        IEnumerable<Meting> GeefMetingen();
        void DoeMetingen();
    }
}
