using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;

namespace DND5eAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDbContext") ?? throw new InvalidOperationException("Connection string 'ApiDbContext' not found.")));

            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            var app = builder.Build();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.MapControllers();

            app.UseSwagger();

            app.Run();
        }
    }
}
