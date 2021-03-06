﻿using NUnit.Framework;
using System;
using System.Linq;
using Car;

namespace _5kyu.Tests
{
    [TestFixture]
    public class Car1ExampleTests
    {
        [Test]
        public void TestMotorStartAndStop()
        {
            var car = new Car.Car();

            Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");

            car.EngineStart();

            Assert.IsTrue(car.EngineIsRunning, "Engine should be running.");

            car.EngineStop();

            Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");
        }

        [Test]
        public void TestFuelConsumptionOnIdle()
        {
            var car = new Car.Car(1);

            car.EngineStart();

            Enumerable.Range(0, 3000).ToList().ForEach(s => car.RunningIdle());

            Assert.AreEqual(0.10, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
        }

        [Test]
        public void TestFuelTankDisplayIsComplete()
        {
            var car = new Car.Car(60);

            Assert.IsTrue(car.fuelTankDisplay.IsComplete, "Fuel tank must be complete!");
        }

        [Test]
        public void TestFuelTankDisplayIsOnReserve()
        {
            var car = new Car.Car(4);

            Assert.IsTrue(car.fuelTankDisplay.IsOnReserve, "Fuel tank must be on reserve!");
        }

        [Test]
        public void TestRefuel()
        {
            var car = new Car.Car(5);

            car.Refuel(40);

            Assert.AreEqual(45, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
        }
    }
}