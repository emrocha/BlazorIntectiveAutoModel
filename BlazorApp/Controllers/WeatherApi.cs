using BlazorApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
{
    public class WeatherApi(IWeatherService _service) : Controller
    {

        // GET: WeatherApi/GetForecasts
        [Route("GetForecasts")]
        public async Task<ActionResult<WeatherForecast>> GetForecasts()
        {
            var result = await _service.GetForecasts();
            return Ok(result);
        }

    }
}
