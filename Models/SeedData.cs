using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UIPath.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ProjectContext context = app.ApplicationServices.GetRequiredService<ProjectContext>();
            context.Database.Migrate();

            // if (!context.Students.Any())
            // {
            //     context.Students.Add(new Student { FirstName = "", LastName = "", Phone = "", Mail = "" });
            // }
        }
    }
}

// dotnet ef migrations add initialize
// dotnet ef database update