namespace Myuzeek.Data;

using Microsoft.EntityFrameworkCore;

public class MyuzeekDbContext : DbContext
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
