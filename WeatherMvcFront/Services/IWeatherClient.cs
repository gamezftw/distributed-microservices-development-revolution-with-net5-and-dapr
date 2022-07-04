namespace WeatherMvcFront.Services;

public interface IWeatherClient
{
    Task<IEnumerable<WeatherForecast>> GetWeather();
}