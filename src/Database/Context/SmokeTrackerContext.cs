using Microsoft.EntityFrameworkCore;
using SmokeTracker.Database.DatabaseEntities;

namespace SmokeTracker.Database.Context;
public class SmokeTrackerContext : DbContext
{
    public DbSet<SmokeLog> SmokeLogs { get; set; }
    public SmokeTrackerContext(DbContextOptions<SmokeTrackerContext> options) : base(options) { }
}
