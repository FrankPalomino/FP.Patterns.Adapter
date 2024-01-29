namespace FP.Patterns.Adapter.Exercice3
{
    public class TemperatureAdapter : ITemperature
    {
        private readonly CelsiusTemperature _celsiusTemperature;

        public TemperatureAdapter(CelsiusTemperature celsiusTemperature)
        {
            _celsiusTemperature = celsiusTemperature;
        }
        public void Display()
        {

            Console.WriteLine($"The temperature is: {GetTemperature()} Fahrenheit.");
        }

        public double GetTemperature()
        {
            return (_celsiusTemperature.GetTemperature() * 9 / 5) + 32;
        }
    }
}
