using weather_monitoring.Domin;
using weather_monitoring.ExtensionMethod;
using weather_monitoring.Factory;
using weather_monitoring.Interface;

namespace weather_monitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The application reads data from a file");

            string weatherData = "Data.Weather Data.txt".ReadFile();

            WeatherDataParserFactory dataParserFactory = new WeatherDataParserFactory();
            var weatherDataObj = dataParserFactory.TryParse(weatherData);

            Console.WriteLine(weatherDataObj);

            string botsData = "Data.Bots Data.json".ReadFile();

            var weatherBots = botsData.DeserilizeFromJsonString<WeatherBots>();

            AttachBots(ref weatherDataObj, weatherBots);

            weatherDataObj.Notify();

            Console.ReadLine();
        }
        static void AttachBots(ref WeatherData data, WeatherBots bots)
        {
            var properties = bots.GetType().GetProperties();
            foreach (var property in properties)
            {
                var name = property.Name;
                var botInstance = (IWeatherBot)property.GetValue(bots);

                data.Attach(botInstance);
            }
        }
    }
}
