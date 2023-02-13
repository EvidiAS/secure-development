namespace EvidiAS.SecureDevelopment.Services;

public class WeatherForecastService
{
  private static readonly string[] Summaries = new[]
  {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  };

  public WeatherForecastService() { }

  public WeatherForecast GetForecast()
    => new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.UtcNow),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    };
}