namespace WeerEventsApi.Facade.Dto;

public class MetingDto
{
    public required DateTime Tijdstip { get; set; }
    public required double Waarde { get; set; }
    public required string Eenheid { get; set; }
}