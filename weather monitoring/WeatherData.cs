namespace weather_monitoring
{
    public class WeatherData
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public override string ToString()
        {
            return $"Location: {Location}, Temperature: {Temperature}, Humidity: {Humidity}";  
        }
    }
}
