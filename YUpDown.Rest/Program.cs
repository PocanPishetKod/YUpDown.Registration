using YUpDown.Common;
using YUpDown.DependenciesSetup;

namespace YUpDown.Rest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var typedConfig = builder.Configuration.Get<Configuration>();

            builder.Services.AddApplication(typedConfig!);

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            //app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}