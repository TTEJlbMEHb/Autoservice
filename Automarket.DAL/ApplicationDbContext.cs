using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Automarket.Domain.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("User").HasKey(x => x.Id);

                builder.HasData(new User[]
                {
                    new User()
                    {
                        Id = 1,
                        Username = "admin",
                        Email = "secauto.admin@gmail.com",
                        Name = "Vlad",
                        Lastname = "Linnik",
                        Password = HashPasswordHelper.HashPassword("adminvlad"),
                        Age = 19,
                        Role = Role.Admin
                    },
                    new User()
                    {
                        Id = 2,
                        Username = "administrator",
                        Email = "secauto.administrator@gmail.com",
                        Name = "Dimasik",
                        Lastname = "Hranoskyi",
                        Password = HashPasswordHelper.HashPassword("admindima"),
                        Age = 19,
                        Role = Role.Administrator
                    }
                });
            });
        }
    }
}
