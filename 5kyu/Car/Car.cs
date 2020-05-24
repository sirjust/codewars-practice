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

        public void Refuel(double liters) 
        {
            fuelTank.Refuel(liters);
            fuelTankDisplay.FillLevel = fuelTank.FillLevel;
        }

        public void RunningIdle() 
        {
            engine.Consume(.0003);
            fuelTank.Consume(.0003);
            fuelTankDisplay.IsOnReserve = fuelTank.IsOnReserve;
            fuelTankDisplay.IsComplete = fuelTank.IsComplete;
            fuelTankDisplay.FillLevel = fuelTank.FillLevel;
        }

        public Car()
        {
            engine = new Engine();
            fuelTank = new FuelTank();
            fuelTankDisplay = new FuelTankDisplay();
        }

        public Car(double fuelLevel = 20)
        {
            engine = new Engine();
            fuelTank = new FuelTank() { FillLevel = fuelLevel, IsOnReserve = fuelLevel < 5, IsComplete = fuelLevel == 60 };
            fuelTankDisplay = new FuelTankDisplay() { FillLevel = fuelTank.FillLevel, IsOnReserve = fuelTank.IsOnReserve, IsComplete = fuelTank.IsComplete };
        }
    }

    public class Engine : IEngine
    {
        public bool IsRunning { get; set; }

        public void Consume(double liters = .0003)
        {

        }

        public void Start() 
        {
            IsRunning = true;
        }

        public void Stop() 
        {
            IsRunning = false;
        }
    }

    public class FuelTank : IFuelTank
    {
        public double FillLevel { get; set; }

        public bool IsOnReserve { get; set; }

        public bool IsComplete { get; set; }

        public void Consume(double liters) 
        {
            FillLevel = Math.Round(FillLevel - liters, 10);
        }

        public void Refuel(double liters) 
        {
            var maximum = 60;
            if (FillLevel + liters > maximum) FillLevel = maximum;
            else FillLevel = FillLevel + liters;
            if (FillLevel < 5) IsOnReserve = true;
            else IsOnReserve = false;
            if (FillLevel == maximum) IsComplete = true;
            else IsComplete = false;
        }
    }

    public class FuelTankDisplay : IFuelTankDisplay
    {
        public double FillLevel { get; set; }

        public bool IsOnReserve { get; set;  }

        public bool IsComplete { get; set; }
    }
}