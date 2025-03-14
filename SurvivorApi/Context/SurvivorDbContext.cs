using Microsoft.EntityFrameworkCore;
using SurvivorApi.Entities;

namespace SurvivorApi.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
