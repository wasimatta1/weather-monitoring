
namespace weather_monitoring.Interface
{
    public interface IWeatherDataParser
    {
        WeatherData TryParse(string input);
    }
}
