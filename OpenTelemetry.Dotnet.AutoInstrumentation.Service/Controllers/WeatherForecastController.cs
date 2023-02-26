using Microsoft.AspNetCore.Mvc;

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastContext _weatherForecastContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastContext weatherForecastContext)
        {
            _logger = logger;
            _weatherForecastContext = weatherForecastContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var data= _weatherForecastContext.WeatherForecasts.ToList();
            return data;
        }
    }
}