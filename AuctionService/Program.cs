namespace AuctionService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.c   
            builder.Services.AddControllers();
            
            var app = builder.Build();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

            Console.WriteLine();
        }
    }
}