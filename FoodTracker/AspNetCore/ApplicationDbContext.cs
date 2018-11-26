using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers {
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<FoodRecord> FoodRecords { get; set; }
  }
}