using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Loan.API
{
    public class Program
    {
        // Development branch.
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            // this is for testing.
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
