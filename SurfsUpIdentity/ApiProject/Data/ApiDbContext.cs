using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
                : base(options)
            { }
            public DbSet<City> Citys { get; set; }
            public DbSet<Equipment> Equipments { get; set; }
            public DbSet<Picture> Pictures { get; set; }
            public DbSet<Renting> Rentings { get; set; }

            public DbSet<SurfSpot> SurfSpots { get; set; }
            public DbSet<SpotReview> SpotReviews { get; set; }
            public DbSet<User> Users { get; set; }
            //public DbSet<UserReview> UserReview { get; set;             
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<City>().ToTable("City");
                modelBuilder.Entity<Equipment>().ToTable("Equipment");
                modelBuilder.Entity<Picture>().ToTable("Picture");
                modelBuilder.Entity<Renting>().ToTable("Renting");
                modelBuilder.Entity<User>().ToTable("User");
                modelBuilder.Entity<SurfSpot>().ToTable("SurfSpot");
                modelBuilder.Entity<SpotReview>().ToTable("SpotReview");
            }
        }
    }
