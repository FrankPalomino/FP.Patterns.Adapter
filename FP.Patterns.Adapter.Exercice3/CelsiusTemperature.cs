namespace FP.Patterns.Adapter.Exercice3
{
    public class CelsiusTemperature : ITemperature
    {
        private readonly double _temperature;

        public CelsiusTemperature(double temperature)
        {
            _temperature = temperature;
        }
        public void Display()
        {
            Console.WriteLine($"The temperature is: {_temperature} Celsius.");
        }

        public double GetTemperature()
        {
            return _temperature;
        }
    }
}
