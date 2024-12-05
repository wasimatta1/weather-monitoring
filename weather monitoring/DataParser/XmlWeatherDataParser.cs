using weather_monitoring.Domin;
using weather_monitoring.ExtensionMethod;
using weather_monitoring.Interface;

namespace weather_monitoring.DataParser
{
    public class XmlWeatherDataParser : IWeatherDataParser
    {
        public WeatherData? TryParse(string input) => input.DeserializeFromXmlString<WeatherData>();
    }
}
