namespace BlazorApp.Model;

public interface IWeatherService
{
    public Task<WeatherForecast[]?> GetForecasts();
}
