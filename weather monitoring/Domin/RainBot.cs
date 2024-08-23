namespace weather_monitoring.Domin
{
    public class RainBot : Bot
    {
        public virtual int HumidityThreshold { get; set; }

        public override bool IsActive(WeatherData data)
        {
            if (!Enabled)
                return false;
            if (HumidityThreshold < data.Humidity)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"RainBot: Enabled: {Enabled}, Message: {Message}, HumidityThreshold: {HumidityThreshold}";
        }
    }
}
