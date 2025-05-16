namespace WeerEventsApi.Model.Metingen.Repositories
{
    public interface IMetingRepository
    {
        IEnumerable<Meting> GeefMetingen();
        void DoeMetingen();
    }
}
