
using weather_monitoring.Domin;

namespace weather_monitoring.Interface
{
    public interface IWeatherDataParser
    {
        WeatherData TryParse(string input);
    }
}
