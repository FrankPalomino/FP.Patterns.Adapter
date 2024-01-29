using FP.Patterns.Adapter.Exercice3;

ITemperature celcius = new CelsiusTemperature(25);
ITemperature fahrenheit = new FahrenheitTemperature(25);
ITemperature celciusAdapter = new TemperatureAdapter((CelsiusTemperature)celcius);

celcius.Display();
fahrenheit.Display();
celciusAdapter.Display();