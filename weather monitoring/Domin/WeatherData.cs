using weather_monitoring.Interface;

namespace weather_monitoring.Domin
{
    public class WeatherData : IWeatherData
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        private List<IWeatherBot> weatherBots = new List<IWeatherBot>();

        public void Attach(IWeatherBot weatherBot)
        {
            this.weatherBots.Add(weatherBot);
        }

        public void Detach(IWeatherBot weatherBot)
        {
            this.weatherBots.Remove(weatherBot);
        }

        public void Notify()
        {
            foreach (var weatherBot in weatherBots)
            {
                weatherBot.Update(this);
            }
        }

        public override string ToString()
        {
            return $"Location: {Location}, Temperature: {Temperature}, Humidity: {Humidity}";
        }
    }
}
