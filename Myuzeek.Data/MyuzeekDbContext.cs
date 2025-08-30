namespace Myuzeek.Data;

using Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class MyuzeekDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public MyuzeekDbContext(DbContextOptions<MyuzeekDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
