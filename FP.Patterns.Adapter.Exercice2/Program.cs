using FP.Patterns.Adapter.Exercice2;
using FP.Patterns.Adapter.Exercice2.External;

IMeteoSensor oldSensor = new OldSensor();
ProcessData(oldSensor);

INewMeteoSensor newSensor = new NewSensor();
SensorAdapter adapter = new SensorAdapter(newSensor);
ProcessData(adapter);

static void ProcessData(IMeteoSensor meteoSensor)
{
    string datos = meteoSensor.GetData();
    Console.WriteLine(datos);
}