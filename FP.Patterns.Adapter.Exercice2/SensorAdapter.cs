using FP.Patterns.Adapter.Exercice2.External;

namespace FP.Patterns.Adapter.Exercice2
{
    public class SensorAdapter : IMeteoSensor
    {
        private readonly INewMeteoSensor _newSensor;

        public SensorAdapter(INewMeteoSensor newSensor)
        {
            _newSensor = newSensor;
        }

        public string GetData()
        {
            return _newSensor.GetInfo();
        }
    }
}
