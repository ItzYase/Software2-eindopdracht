using WeerEventsApi.Facade.Controllers;
using WeerEventsApi.Logging;
using WeerEventsApi.Model.Steden.Managers;
using WeerEventsApi.Model.Steden.Repositories;
using WeerEventsApi.Model.Weerberichts.Managers;
using WeerEventsApi.Model.Weerberichts.Repositories;
using WeerEventsApi.Model.Weerstations.Managers;
using WeerEventsApi.Model.Weerstations.Repositories;
using WeerEventsApi.Model.Weerberichts.Proxy;
using WeerEventsApi.Model.Weerberichts.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMetingLogger>(MetingLoggerFactory.Create(true,true));
builder.Services.AddSingleton<IStadRepository, StadRepository>();
builder.Services.AddSingleton<IStadManager, StadManager>();
builder.Services.AddSingleton<IService, Service>();
builder.Services.AddSingleton<IWeerberichtProxy, WeerberichtProxy>();
builder.Services.AddSingleton<IWeerstationRepository, WeerstationRepository>();
builder.Services.AddSingleton<IWeerstationManager, WeerstationManager>();
builder.Services.AddSingleton<IWeerberichtRepository, WeerberichtRepository>();
builder.Services.AddSingleton<IWeerberichtManager, WeerberichtManager>();
builder.Services.AddSingleton<IDomeinController, DomeinController>();

var app = builder.Build();

app.MapGet("/", () => "WEER - WEERsomstandigheden Evalueren En Rapporteren");

app.MapGet("/steden", (IDomeinController dc) => dc.GeefSteden());

app.MapGet("/weerstations", (IDomeinController dc) => dc.GeefWeerstations());

app.MapGet("/metingen", (IDomeinController dc) => dc.GeefMetingen());

app.MapGet("/commands/meting-command", (IDomeinController dc) => dc.DoeMetingen());

app.MapGet("/weerbericht", (IDomeinController dc) => dc.GeefWeerbericht());

app.Run();