namespace FP.Patterns.Adapter
{
    internal interface IEngine
    {
        void Accelerate();
        void Start();
        void Stop();
        void Refuel();
    }
}
