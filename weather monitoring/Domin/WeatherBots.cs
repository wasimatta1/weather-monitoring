namespace weather_monitoring.Domin
{
    public class WeatherBots
    {
        public RainBot Rain { get; set; }
        public SunBot Sun { get; set; }
        public SnowBot Snow { get; set; }

        public override string ToString()
        {
            return Rain.ToString() + "\n" + Sun.ToString() + "\n" + Snow.ToString();
        }
    }
}
