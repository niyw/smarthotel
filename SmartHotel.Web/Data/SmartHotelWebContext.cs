using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartHotel.Web.Models;

namespace SmartHotel.Web.Data
{
    public class SmartHotelWebContext : DbContext
    {
        public SmartHotelWebContext (DbContextOptions<SmartHotelWebContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().Property(h => h.Id).UseHiLo("hotelseq");            
            modelBuilder.Entity<Hotel>().Property(h => h.CheckinTime).HasColumnType("time");
            modelBuilder.Entity<Hotel>().Property(h => h.CheckoutTime).HasColumnType("time");
            modelBuilder.Entity<City>().Property(c => c.Id).ValueGeneratedNever();
        }

    }
}
