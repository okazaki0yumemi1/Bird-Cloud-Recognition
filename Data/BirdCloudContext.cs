using Microsoft.EntityFrameworkCore;

public class BirdCloudContext : DbContext
    {
        public DbSet<Bird> Birds { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }