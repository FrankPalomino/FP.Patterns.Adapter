namespace FP.Patterns.Adapter
{
    internal class ElectricEngineAdapter : IEngine
    {
        ElectricEngine _electricEngine = new ElectricEngine();
        public void Accelerate()
        {
            _electricEngine.Move();
        }

        public void Refuel()
        {
            _electricEngine.TurnOff();
            _electricEngine.PlugIn();
        }

        public void Start()
        {
            _electricEngine.TurnOn();
            _electricEngine.Activate();
        }

        public void Stop()
        {
            _electricEngine.Deactivate();
            _electricEngine.Stop();
        }
    }
}
