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
            modelBuilder.Entity<Country>().HasData(new Country { id = 1, country_name = "Kina", country_name_eng = "China", country_code = "CHN" },
                                                   new Country { id = 2, country_name = "Hrvatska", country_name_eng = "Croatia", country_code = "HRV" },
                                                   new Country { id = 3, country_name = "Uganda", country_name_eng = "Uganda", country_code = "UGA" });
            modelBuilder.Entity<City>().HasData(new City { id = 1, country_id = 2, city_name = "Zagreb", latitude = 45.8150m, longitude = 15.9819m },
                                                new City { id = 2, country_id = 2, city_name = "Split", latitude = 43.5147m, longitude = 16.4435m },
                                                new City { id = 3, country_id = 1, city_name = "Peking", latitude = 39.9042m, longitude = 116.4074m },
                                                new City { id = 4, country_id = 1, city_name = "Šangaj", latitude = 31.2304m, longitude = 121.4737m },
                                                new City { id = 5, country_id = 3, city_name = "Kampala", latitude = 0.3476m, longitude = 32.5825m },
                                                new City { id = 6, country_id = 3, city_name = "Gulu", latitude = 2.7724m, longitude = 32.2881m});
        }
    }
}
