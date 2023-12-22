namespace FP.Patterns.Adapter.Exercice2.External
{
    public class OldSensor : IMeteoSensor
    {
        public string GetData()
        {
            return "Toma Datos";
        }
    }
}
