
using weather_monitoring.Interface;

namespace weather_monitoring.Domin
{
    public class SnowBot : IWeatherBot
    {
        public bool Enabled { get; set; }
        public int TemperatureThreshold { get; set; }
        public string Message { get; set; }

        public void Update(IWeatherData weatherData)
        {
            if (!Enabled) return;
            if ((weatherData as WeatherData).Humidity < TemperatureThreshold)
            {
                Console.WriteLine($"{nameof(SnowBot)} activated!");
                Console.WriteLine(Message);
            }
        }
    }
}
