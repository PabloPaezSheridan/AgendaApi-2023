using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AgendaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User()
                    {
                        Email = "email@email.com",
                        Name = "Pablo",
                        Id = 1,
                        Password = "pass"
                    },
                    new User()
                    {
                        Email = "email@email.com",
                        Name = "Pablo",
                        Id = 2,
                        Password = "pass"
                    },
                    new User()
                    {
                        Email = "admin@admin.com",
                        Name = "admin",
                        Role = Models.UserRoleEnum.Admin,
                        Id = 3,
                        Password = "pass"
                    }
                    );

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.User);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Contacts)
                .WithOne(c => c.User);

            base.OnModelCreating(modelBuilder);

        }
    }
}
