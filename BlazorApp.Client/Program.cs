using BlazorApp.Client.Services;
using BlazorApp.Model;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddScoped(sp => new HttpClient
        {
            BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        });

        builder.Services.AddTransient<IWeatherService, WeatherServiceClient>();

        await builder.Build().RunAsync();
    }
}
