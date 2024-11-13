using Microsoft.EntityFrameworkCore;
using TypesfRelationships.Model;

namespace TypesfRelationships.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<HouseModel> Houses { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<ResidentModel> Residents{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<HouseModel>()
            //    .WithOne(e => e.Address)
            //    .HasForeignKey(e => e.AddressId)
            //    .HasPrincipalKey(e => e.Id);
        }

    }
}
