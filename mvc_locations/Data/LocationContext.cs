using Microsoft.EntityFrameworkCore;
using mvc_locations.Models;

namespace mvc_locations.Data
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Zadatak:
        // kreirati metodu OnModelCreating(ModelBuilder modelBuilder)
        // Napraviti seed podataka za:
        // Minimalno dvije nasumične države s pripadajućim podacima
        // minimalno šest nasumičnih gradova s pripadajućim podacima

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            
        }
    }
}
