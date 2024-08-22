using weather_monitoring.Factory;

namespace weather_monitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The application reads data from a file");

            Type type = typeof(Program);
            var assembly = type.Assembly;

            var stream = assembly.GetManifestResourceStream(type, "Data.Weather Data.txt");
            if (stream is null)
            {
                Console.WriteLine("Resource not found.");
                return;
            }
            string weatherData = new StreamReader(stream).ReadToEnd();

            WeatherDataParserFactory dataParserFactory = new WeatherDataParserFactory();
            var weatherDataObj = dataParserFactory.TryParse(weatherData);

            Console.WriteLine(weatherDataObj);
            Console.ReadLine();
        }
    }
}
