using FMS.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Utils.Data.Extensions;

namespace FMS.Data.Contexts
{
    public class FMSContext : DbContext
    {
        public FMSContext() { }
        public FMSContext(DbContextOptions<FMSContext> options)
            : base(options)
        {
        }
        public virtual DbSet<StatusType> StatusTypes { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<WingDetail> WingDetails { get; set; }

        public virtual DbSet<LocationDetail> LocationDetails { get; set; }

        public virtual DbSet<FloorDetail> FloorDetails { get; set; }

        public virtual DbSet<DeskDetail> DeskDetails { get; set; }

        public virtual DbSet<BuildingDetail> BuildingDetails { get; set; }

        public virtual DbSet<BookingDetail> BookingDetails { get; set; }

        public virtual DbSet<UserPreference> UserPreferences { get; set; }

        public virtual DbSet<PermissionGroup> PermissionGroup { get; set; }

        public virtual DbSet<UserPermissionGroup> UserPermissionGroup { get; set; }

        public virtual DbSet<MapConfiguration> MapConfiguration { get; set; }

        public virtual DbSet<AdminConfiguration> AdminConfiguration { get; set; }

        public virtual DbSet<DeskAllocateDetail> DeskAllocateDetail { get; set; }

        public virtual DbSet<PhotoType> PhotoType { get; set; }

        public virtual DbSet<PhotoDetails> PhotoDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplySimpleIndex()
                .ApplyDecimalPrecision()
                .RemoveCascadeDeleteConvention();

        }
    }
}
