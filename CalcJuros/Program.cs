using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CalcJuros
{
    /// <summary>
    /// Web API CalcJuros
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
