using weather_monitoring.ExtensionMethod;
using weather_monitoring.Factory;

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
            Console.ReadLine();
        }
    }
}
