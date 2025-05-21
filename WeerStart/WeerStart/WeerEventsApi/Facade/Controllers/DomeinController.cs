using WeerEventsApi.Facade.Dto;
using WeerEventsApi.Model.Steden.Managers;
using WeerEventsApi.Model.Weerberichts.Managers;
using WeerEventsApi.Model.Weerstations.Managers;

namespace WeerEventsApi.Facade.Controllers;

public class DomeinController : IDomeinController
{
    private readonly IStadManager _stadManager;
    private readonly IWeerberichtManager _weerberichtManager;
    private readonly IWeerstationManager _weerstationManager;

    public DomeinController(IStadManager stadManager, IWeerberichtManager weerbericht, IWeerstationManager weerstationManager)
    {
        _stadManager = stadManager;
        _weerberichtManager = weerbericht;
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
            stad = w.stad,
            meting = w.metingen
        });
    }

    public IEnumerable<MetingDto> GeefMetingen()
    {
        return _weerstationManager.GeefMetingen().Select(m => new MetingDto
        {
            Waarde = m.Waarde,
            Tijdstip = m.Tijdstip,
            Eenheid = m.Eenheid.ToString()
        });
    }

    public void DoeMetingen()
    {
        _weerstationManager.DoeMeting();
    }

    public WeerBerichtDto GeefWeerbericht()
    {
        var weerbericht = _weerberichtManager.GeefWeerbericht(_weerstationManager.GeefMetingen());
        return new WeerBerichtDto
        {
            DateTime = weerbericht.DateTime,
            Inhoud = weerbericht.Inhoud
        };
    }
}