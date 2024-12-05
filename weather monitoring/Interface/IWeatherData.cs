namespace weather_monitoring.Interface
{
    public interface IWeatherData
    {
        void Attach(IWeatherBot weatherBot);

        void Detach(IWeatherBot weatherBot);

        void Notify();
    }
}
