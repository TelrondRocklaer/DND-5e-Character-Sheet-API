using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DND5eAPI.Data;
using DND5eAPI.Models;
namespace DND5eAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDbContext") ?? throw new InvalidOperationException("Connection string 'ApiDbContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

            //public int Modifier { get; set; }
            //public bool AdvantageOnSavingThrows { get; set; }
            //public bool AdvantageOnAbilityChecks { get; set; }
            //public bool DisadvantageOnSavingThrows { get; set; }
            //public bool DisadvantageOnAbilityChecks { get; set; }
        }
    }
}
