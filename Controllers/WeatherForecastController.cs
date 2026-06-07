using Microsoft.AspNetCore.Mvc;

namespace DevopsLearn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching", "Blazing", "Sizzling", "Torrid", "Boiling", "Broiling","Searing", "Fiery", "Burning", "Scalding", "Blistering", "Incendiary", "Infernal", "Volcanic", "Suffocating", "Sweltry", "Tropical", "Sultry", "Humid"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
