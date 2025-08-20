using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;

namespace HYBS2025.Persistance.Context
{
    public class HYBSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=AALAS\\SQLEXPRESS; database=DBHYBS2025;integrated security=true;TrustServerCertificate=true;");
        }

        public DbSet<Punishment> Punishments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Filling> Fillings { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<OtherStructure> OtherStructures { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<infrastructurework> infrastructureworks { get; set; }
        public DbSet<SmallVehicle> SmallVehicles { get; set; }
        public DbSet<BalanceSmall> BalanceSmalls { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<CompanyDocument> CompanyDocuments { get; set; }
        public DbSet<CompanyBalance> CompanyBalances { get; set; }
        public DbSet<Peyzaj> Peyzajs { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Mahalle> Mahalleler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Structure ilişkileri
            modelBuilder.Entity<Structure>()
                .HasOne(s => s.Company)
                .WithMany(c => c.Structures)
                .HasForeignKey(s => s.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Structure>()
                .HasOne(s => s.City)
                .WithMany(c => c.Structures)
                .HasForeignKey(s => s.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Structure>()
                .HasOne(s => s.District)
                .WithMany(d => d.Structures)
                .HasForeignKey(s => s.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Structure>()
                .HasOne(s => s.Neighborhood)
                .WithMany(n => n.Structures)
                .HasForeignKey(s => s.NeighborhoodId)
                .OnDelete(DeleteBehavior.Restrict);

            // OtherStructure ilişkileri
            modelBuilder.Entity<OtherStructure>()
                .HasOne(o => o.Company)
                .WithMany(c => c.OtherStructures)
                .HasForeignKey(o => o.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OtherStructure>()
                .HasOne(o => o.City)
                .WithMany(c => c.OtherStructures)
                .HasForeignKey(o => o.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OtherStructure>()
                .HasOne(o => o.District)
                .WithMany(d => d.OtherStructures)
                .HasForeignKey(o => o.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OtherStructure>()
                .HasOne(o => o.Neighborhood)
                .WithMany(n => n.OtherStructures)
                .HasForeignKey(o => o.NeighborhoodId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
