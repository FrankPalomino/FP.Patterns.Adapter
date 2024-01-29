namespace FP.Patterns.Adapter.Exercice3
{
    internal class FahrenheitTemperature : ITemperature
    {
        private readonly double _temperature;

        public FahrenheitTemperature(double temperature)
        {
            _temperature = temperature;
        }
        public void Display()
        {
            Console.WriteLine($"The temperature is: {_temperature} Fahrenheit.");
        }

        public double GetTemperature()
        {
            return _temperature;
        }
    }
}
