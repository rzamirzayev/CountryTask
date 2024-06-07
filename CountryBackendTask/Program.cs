
using CountryBackendTask.Models.Contexts;
using CountryBackendTask.Models.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CountryBackendTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<DataContext>(cfg => { cfg.UseInMemoryDatabase("CountriesDb"); });
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
            app.Seed();
            app.Run();
        }
    }
}