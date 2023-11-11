using Bogus;
using SmokeTracker.Database.DatabaseEntities;

namespace SmokeTracker.Database.SeedData;

public static class SeedDataGenerator
{
    public static IEnumerable<SmokeLog> GetSmokeLogsSeedData()
    {
        int smokeLogIds = 0;
        var data = new Faker<SmokeLog>().RuleFor(s => s.Id, smokeLogIds++)
                                        .RuleFor(s => s.SmokeDate, f => f.Date.Soon())
                                        .RuleFor(s => s.DurationInMinutes, f => f.Random.Int(5, 10))
                                        .RuleFor(s => s.Craving, f => f.PickRandom<Scale>())
                                        .RuleFor(s => s.Satisfaction, f => f.PickRandom<Scale>())
                                        .RuleFor(s => s.Notes, f => f.Lorem.Sentences())
                                        .Generate(100);
        return data;
    }
}
