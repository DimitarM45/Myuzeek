namespace Myuzeek.IdentityServer;

using Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<MyuzeekIdentityDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
        {
            options.Lockout.MaxFailedAccessAttempts = 6;
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedEmail = true;
        })
            .AddEntityFrameworkStores<MyuzeekIdentityDbContext>()
            .AddDefaultTokenProviders();

        builder.Services.AddIdentityServer()
                .AddAspNetIdentity<IdentityUser>()
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = dbOptions =>
                        dbOptions.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                        sql => sql.MigrationsAssembly("Myuzeek.IdentityServer"));
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = dbOptions =>
                        dbOptions.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                        sql => sql.MigrationsAssembly("Myuzeek.IdentityServer"));
                    options.EnableTokenCleanup = true;
                })
            .AddLicenseSummary();

        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();

        return builder.Build();
    }
}
