using EvidiAS.SecureDevelopment.Services;
using Microsoft.AspNetCore.Mvc;

namespace EvidiAS.SecureDevelopment.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly WeatherForecastService _forecastService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
        WeatherForecastService forecastService,
        ILogger<WeatherForecastController> logger)
    {
        _forecastService = forecastService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast Get()
    {
        return _forecastService.GetForecast();
    }
}
