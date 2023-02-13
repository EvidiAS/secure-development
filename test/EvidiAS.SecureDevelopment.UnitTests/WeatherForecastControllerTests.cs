using EvidiAS.SecureDevelopment.Services;
namespace EvidiAS.SecureDevelopment.UnitTests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void GetWeatherForecast_ReturnForecastWithTempsInRange()
    {
        // Arrange
        var forecastService = new WeatherForecastService();

        // Act
        var forecast = forecastService.GetForecast();
        
        // Assert
        Assert.InRange(forecast.TemperatureC, -20, 55);
    }
}