using Myuzeek.IdentityServer;

public class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        WebApplication app = builder
            .ConfigureServices();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyuzeekIdentityServer API V1");
                c.RoutePrefix = string.Empty;
            });
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseIdentityServer();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}