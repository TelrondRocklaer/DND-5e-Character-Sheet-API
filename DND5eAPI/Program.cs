using Microsoft.EntityFrameworkCore;
using DND5eAPI.Data;
using DND5eAPI.Utilities;
namespace DND5eAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDbContext") ?? throw new InvalidOperationException("Connection string 'ApiDbContext' not found.")));

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new EffectConverter());
            });

            builder.Services.AddSwaggerGen();

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

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.MapControllers();

            app.UseSwagger();

            app.Run();
        }
    }
}
