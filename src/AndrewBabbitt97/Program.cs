using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AndrewBabbitt97
{
    /// <summary>
    /// The program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The program entry point
        /// </summary>
        /// <param name="args">The command line arguments</param>
        /// <returns>A task</returns>
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            await builder.Build().RunAsync();
        }
    }
}
