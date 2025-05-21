namespace WeerEventsApi.Model.Weerberichts.Repositories
{
    public interface IWeerberichtRepository
    {
        IEnumerable<Weerbericht> GeefWeerberichten();
    }
}
