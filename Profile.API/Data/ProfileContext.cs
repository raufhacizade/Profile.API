using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Profile.API.Models;

namespace Profile.API.Data
{
  public class ProfileContext : DbContext
  {
    public ProfileContext(DbContextOptions<ProfileContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      List<User> seedUsers = new List<User>();
      for (int i = 1; i <= 100; i++)
      {
        seedUsers.Add(new User { 
          Id = i,
          FirstName = "DummyName_"+i,
          LastName = "DummyLastName_" + i,
          Address = "Dummy Address No_"+i,
          Email = "dummy" + i +"@gmail.com",
          IsDeleted = false,
          CreatedOn = DateTime.Now
        });
      }

      modelBuilder.Entity<User>()
            .Property(r => r.Id)
            .ValueGeneratedOnAdd();
      modelBuilder.Entity<User>().HasData(seedUsers);
    }
  }
}
