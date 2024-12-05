
using System.Reflection;
using weather_monitoring.Domin;
using weather_monitoring.Interface;

namespace weather_monitoring.Factory
{
    public class WeatherDataParserFactory
    {
        private readonly List<IWeatherDataParser> parsers;

        public WeatherDataParserFactory()
        {
            parsers = LoadParsers();
        }

        private List<IWeatherDataParser> LoadParsers()
        {
            var parserType = typeof(IWeatherDataParser);

            List<Type> implementingIDataParser = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => parserType.IsAssignableFrom(t) && !t.IsInterface)
                .ToList();

            return implementingIDataParser
                .Select(Activator.CreateInstance)
                .Cast<IWeatherDataParser>()
                .ToList();
        }

        public WeatherData? TryParse(string input)
        {
            foreach (var parser in parsers)
            {
                var dataParsed = parser.TryParse(input);

                if (!(dataParsed is null))
                {
                    return dataParsed;
                }
            }
            return null;
        }
    }
}
