using Microsoft.AspNetCore.Mvc;

namespace FirstProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecastByQuantity")]
        public IEnumerable<WeatherForecast> Get(int quantity)


        {
            _logger.LogInformation("Metodo get invocado com sucesso!");

            if (quantity <= 0)
            {
                _logger.LogError("Ops. Ocorreu uma falha. Quantity  menor ou igual a 0");

                return null;
            }

            
            
            return Enumerable.Range(1, quantity).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}