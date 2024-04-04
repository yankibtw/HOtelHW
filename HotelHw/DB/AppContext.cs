using Microsoft.EntityFrameworkCore;
using System.IO;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace HotelHw.DB
{
    internal class AppContext : DbContext
    {
        public DbSet<Guests> Guests { get; set; }
        public DbSet<GuestDetails> GuestDetails { get; set; }
        public DbSet<HotelsRoom> HotelsRoom { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string dbPath = Path.Combine(path, "../../DB/hotelDB.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guests>()
                .HasOne(g => g.GuestDetails)
                .WithMany(d => d.Guests)
                .HasForeignKey(g => g.GuestDetailsID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
