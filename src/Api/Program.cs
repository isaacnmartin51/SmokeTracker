using Marten;
using SmokeTracker.Api.Features.AddSmokeLog;
using SmokeTracker.Api.Features.GetSmokeLogs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMarten("Host=localhost;Port=5432;Database=postgres;Username=postgres;password=123").UseLightweightSessions();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

var app = builder.Build();

app.MapAddSmokeLogEndpoint();

app.MapGetSmokeLogsEndpoint();

app.Run();
