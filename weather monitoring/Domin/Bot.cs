namespace weather_monitoring.Domin
{
    public abstract class Bot
    {
        public bool Enabled { get; set; }
        public string Message { get; set; }

        public abstract bool IsActive(WeatherData data);

    }
}
