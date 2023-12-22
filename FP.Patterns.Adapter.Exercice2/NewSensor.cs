namespace FP.Patterns.Adapter.Exercice2
{
    public class NewSensor : INewMeteoSensor
    {
        public string GetInfo()
        {
            return "Toma nuevos datos";
        }
    }
}
