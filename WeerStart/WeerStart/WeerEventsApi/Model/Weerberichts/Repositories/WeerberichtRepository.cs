namespace WeerEventsApi.Model.Weerberichts.Repositories
{
    public class WeerberichtRepository : IWeerberichtRepository
    {
        public IEnumerable<Weerbericht> GeefWeerberichten()
        {
            return WeerberichtProxy.GeefWeerberichten();
        }
    }
}
