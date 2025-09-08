namespace Myuzeek.IdentityServer.Data;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class MyuzeekIdentityDbContext : IdentityDbContext<IdentityUser>
{
    public MyuzeekIdentityDbContext(DbContextOptions<MyuzeekIdentityDbContext> options)
        : base(options) { }
}
