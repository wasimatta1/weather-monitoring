using Newtonsoft.Json;
using weather_monitoring.Interface;
using weather_monitoring.ExtensionMethod;

namespace weather_monitoring.DataParser
{
    public class JsonWeatherDataParser : IWeatherDataParser
    {
        public WeatherData? TryParse(string input) => input.DeserilizeFromJsonString<WeatherData>();

    }
}
