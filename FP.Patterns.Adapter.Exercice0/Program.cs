using FP.Patterns.Adapter;

IEngine gasolineEngine = new GasolineEngine();
gasolineEngine.Start();
gasolineEngine.Accelerate();
gasolineEngine.Stop();
gasolineEngine.Refuel();

IEngine dieselEngine = new DieselEngine();
dieselEngine.Start();
dieselEngine.Accelerate();
dieselEngine.Stop();
dieselEngine.Refuel();

IEngine electricEngineAdapter = new ElectricEngineAdapter();
electricEngineAdapter.Start();
electricEngineAdapter.Accelerate();
electricEngineAdapter.Stop();
electricEngineAdapter.Refuel();

Console.ReadLine();