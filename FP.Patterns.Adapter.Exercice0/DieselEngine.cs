namespace FP.Patterns.Adapter
{
    internal class DieselEngine : IEngine
    {
        public void Accelerate()
        {
            Console.WriteLine("DieselMotor.Accelerate");
        }

        public void Refuel()
        {
            Console.WriteLine("DieselMotor.Refuel");
        }

        public void Start()
        {
            Console.WriteLine("DieselMotor.Start");
        }

        public void Stop()
        {
            Console.WriteLine("DieselMotor.Stop");
        }
    }
}
