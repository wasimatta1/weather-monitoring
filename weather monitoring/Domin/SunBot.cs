namespace weather_monitoring.Domin
{
    public class SunBot : Bot
    {
        public virtual int TemperatureThreshold { get; set; }

        public override bool IsActive(WeatherData data)
        {
            if (!Enabled)
                return false;
            if (TemperatureThreshold > data.Temperature)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"SunBot: Enabled: {Enabled}, Message: {Message}, TemperatureThreshold: {TemperatureThreshold}";
        }
    }
}
