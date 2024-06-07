using CountryBackendTask.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountryBackendTask.Models.Contexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options){ }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
