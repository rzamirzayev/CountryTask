using CountryBackendTask.Models.Entities;

namespace CountryBackendTask.Models.Contexts
{
    public static class DataSeed
    {
        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using(var scope=app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();
                var list = new[]
                {
                 new Country { Id=1,Name = "Azerbaijan", Code = "944" },
                new Country { Id = 2, Name = "USA", Code = "911" },
                new Country { Id = 3, Name = "Brazilia", Code = "626" } };
            
                db.Countries.AddRange(list);
                db.SaveChanges();
            }
            return app;
        }
    }
}
