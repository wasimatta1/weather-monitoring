using weather_monitoring.Factory;

namespace weather_monitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The application read datat from a file");

            string filePath = @"C:\Users\wasim\OneDrive\Desktop\C# project\weather monitoring\weather monitoring\Input .txt";

            string weatherData = File.ReadAllText(filePath);

            WeatherDataParserFactory dataParserFactory = new WeatherDataParserFactory();

           var weatherDataObj = dataParserFactory.GetParser(weatherData);

            Console.WriteLine(weatherDataObj);

            Console.ReadLine();

        }
    }
}
