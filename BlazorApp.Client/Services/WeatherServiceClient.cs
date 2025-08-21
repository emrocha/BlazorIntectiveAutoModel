using BlazorApp.Model;
using System.Net.Http.Json;

namespace BlazorApp.Client.Services;

public class WeatherServiceClient(HttpClient _http) : IWeatherService
{
    public async Task<WeatherForecast[]?> GetForecasts()
    {
        var result = await _http.GetFromJsonAsync<WeatherForecast[]?>("GetForecasts");
        return result;
    }
}
