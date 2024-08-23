using weather_monitoring.Interface;

namespace weather_monitoring.Domin
{
    public class RainBot : IWeatherBot
    {
        public bool Enabled { get; set; }
        public int HumidityThreshold { get; set; }
        public string Message { get; set; }

        public void Update(IWeatherData weatherData)
        {
            if (!Enabled) return;
            if ((weatherData as WeatherData).Humidity > HumidityThreshold)
            {
                Console.WriteLine($"{nameof(RainBot)} activated!");
                Console.WriteLine(Message);
            }
        }
    }
}
