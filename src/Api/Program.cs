using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SmokeTracker.Database.Context;
using SmokeTracker.Database.DatabaseEntities;
using SmokeTracker.Database.SeedData;

var builder = WebApplication.CreateBuilder(args);

//TODO: See about injecting from the other project
builder.Services.AddDbContext<SmokeTrackerContext>(o => o.UseInMemoryDatabase("test"));

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetService<SmokeTrackerContext>();
    db.Database.EnsureCreated();
    db.SmokeLogs.AddRange(SeedDataGenerator.GetSmokeLogsSeedData());
    db.SaveChanges();
}

app.MapGet("/smokelogs", async (SmokeTrackerContext db) =>
{
    return await db.SmokeLogs.ToListAsync();
});

app.MapPost("/smokelogs", async (SmokeLog logRequest, SmokeTrackerContext db) =>
{
    _ = db.Add(logRequest);
    _ = await db.SaveChangesAsync();
});

app.Run();
