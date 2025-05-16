using WeerEventsApi.Facade.Dto;
using WeerEventsApi.Model.Steden.Managers;
using WeerEventsApi.Model.Weerberichts.Managers;
using WeerEventsApi.Model.Weerstations.Managers;
using WeerEventsApi.Model.Metingen.Managers;

namespace WeerEventsApi.Facade.Controllers;

public class DomeinController : IDomeinController
{
    private readonly IStadManager _stadManager;
    private readonly IWeerberichtManager _weerberichtManager;
    private readonly IMetingManager _metingManager;
    private readonly IWeerstationManager _weerstationManager;

    public DomeinController(IStadManager stadManager,IWeerberichtManager weerbericht,IMetingManager metingManager,IWeerstationManager weerstationManager)
    {
        _stadManager = stadManager;
        _weerberichtManager = weerbericht;
        _metingManager = metingManager;
        _weerstationManager = weerstationManager;
    }

    public IEnumerable<StadDto> GeefSteden()
    {
        return _stadManager.GeefSteden().Select(s => new StadDto
        {
            Naam = s.Naam,
            Beschrijving = s.Beschrijving,
            GekendVoor = s.GekendVoor
        });
    }

    public IEnumerable<WeerStationDto> GeefWeerstations()
    {
        return _weerstationManager.GeefWeerstations().Select(w => new WeerStationDto
        {
            
        });
    }

    public IEnumerable<MetingDto> GeefMetingen()
    {
        //TODO
        throw new NotImplementedException();
    }

    public void DoeMetingen()
    {
        //TODO
        throw new NotImplementedException();
    }

    public WeerBerichtDto GeefWeerbericht()
    {
        //TODO
        throw new NotImplementedException();
    }
}