namespace FP.Patterns.Adapter
{
    internal class GasolineEngine : IEngine
    {
        public void Accelerate()
        {
            Console.WriteLine("GasolineEngine.Accelerate");
        }

        public void Refuel()
        {
            Console.WriteLine("GasolineEngine.Refuel");
        }

        public void Start()
        {
            Console.WriteLine("GasolineEngine.Start");
        }

        public void Stop()
        {
            Console.WriteLine("GasolineEngine.Stop");
        }
    }
}
