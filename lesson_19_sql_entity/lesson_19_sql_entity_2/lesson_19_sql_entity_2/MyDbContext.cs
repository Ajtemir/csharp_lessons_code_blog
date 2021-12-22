using Microsoft.EntityFrameworkCore;

namespace lesson_19_sql_entity_2
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
        public MyDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=csharp_2;Username=postgres;Password=postgres");
        }
    }
}