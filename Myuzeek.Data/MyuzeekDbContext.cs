namespace Myuzeek.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

public class MyuzeekDbContext : IdentityDbContext<ApplicationUser>
{
    public MyuzeekDbContext(DbContextOptions<MyuzeekDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
