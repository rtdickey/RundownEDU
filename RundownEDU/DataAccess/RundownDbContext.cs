using Microsoft.EntityFrameworkCore;
using RundownEDU.Interfaces;
using RundownEDU.Models;

namespace RundownEDU.DataAccess;

public class RundownDbContext : DbContext
{
    public RundownDbContext(DbContextOptions<RundownDbContext> options) : base(options) { }
    public DbSet<Person> People { get; set; }
    public DbSet<Rundown> Rundowns { get; set; }
    public DbSet<Segment> Segments { get; set; }
}
