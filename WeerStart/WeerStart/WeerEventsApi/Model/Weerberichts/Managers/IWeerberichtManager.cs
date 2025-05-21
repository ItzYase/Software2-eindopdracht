namespace WeerEventsApi.Model.Weerberichts.Managers
{
    public interface IWeerberichtManager
    {
        IEnumerable<Weerbericht> GeefWeerberichten();
    }
}
