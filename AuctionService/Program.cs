using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

namespace AuctionService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.c   
            builder.Services.AddControllers();

            //db connection configuration
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            //db connection service
            builder.Services.AddDbContext<AuctionDbContext>(data =>
            {
                data.UseNpgsql(connectionString);
            });

            var app = builder.Build();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            app.UseAuthorization();

            app.MapControllers();

            try
            { 
                DbInitializer.InitDb(app);
            }
            catch (Exception message)
            {

                Console.WriteLine(message);
            }

            app.Run();

        }
    }
}