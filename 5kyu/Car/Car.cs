using System;

namespace Car
{
    public class Car : ICar
    {
        public IFuelTankDisplay fuelTankDisplay;
        private IEngine engine;
        private IFuelTank fuelTank;

        public bool EngineIsRunning { get; set; }

        public void EngineStart() 
        {
            engine.Start();
            EngineIsRunning = engine.IsRunning;
        }

        public void EngineStop() 
        {
            engine.Stop();
            EngineIsRunning = false;
        }

        public void Refuel(double liters) { }

        public void RunningIdle() { }

        public Car()
        {
            engine = new Engine();
            fuelTank = new FuelTank();
            fuelTankDisplay = new FuelTankDisplay();
        }

        public Car(double fuelLevel = 20)
        {
            engine = new Engine();
            fuelTank = new FuelTank();
            fuelTankDisplay = new FuelTankDisplay();
        }
    }

    public class Engine : IEngine
    {
        public bool IsRunning { get; set; }

        public void Consume(double liters)
        {
            var timeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);
            while (IsRunning == true) 
            {
                
            }
        }

        public void Start() 
        {
            IsRunning = true;
            Consume(.0003);
        }

        public void Stop() 
        {
            IsRunning = false;
        }
    }

    public class FuelTank : IFuelTank
    {
        public double FillLevel { get; }

        public bool IsOnReserve { get; }

        public bool IsComplete { get; }

        public void Consume(double liters) { }

        public void Refuel(double liters) { }
    }

    public class FuelTankDisplay : IFuelTankDisplay
    {
        public double FillLevel { get; }

        public bool IsOnReserve { get; }

        public bool IsComplete { get; }
    }
}