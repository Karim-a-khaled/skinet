using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

public class AppIdentityDbContext : IdentityDbContext
{
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

    public DbSet<AppUser> AppUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
