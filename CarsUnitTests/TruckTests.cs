using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cars;

namespace CarsUnitTests {

    //Klasa implementująca testy jednostkowe dla klasy Truck.
    [TestClass]
    public class TruckTests {

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_FFFF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_FFFT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.LoadTruck();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_FFTF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_FFTT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.LoadTruck();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_FTFF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.StartEngine();
            truck.Drive();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_FTFT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.LoadTruck();
            truck.StartEngine();
            truck.Drive();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_FTTF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.StartEngine();
            truck.TurnOnAirCond();
            truck.Drive();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_FTTT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();

            //Assert
            Assert.AreEqual(truck.IsTankFull, false);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_TFFF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_TFFT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.LoadTruck();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_TFTF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_TFTT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.LoadTruck();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, false);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_TTFF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.StartEngine();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_TTFT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.LoadTruck();
            truck.StartEngine();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, false);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> fałsz
        [TestMethod]
        public void Truck_TTTF() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.StartEngine();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, false);
        }

        //Test jednostkowy dla samochodu ciężarowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        //IsTruckLoaded / Czy samochód ciężarowy jest załadowany -> prawda
        [TestMethod]
        public void Truck_TTTT() {
            //Arrange
            Truck truck = new Truck();

            //Act
            truck.Refuel();
            truck.StartEngine();
            truck.LoadTruck();
            truck.TurnOnAirCond();
            truck.Drive();
            truck.TurnOffAirCond();
            truck.StopEngine();
            truck.UnloadTruck();
            truck.Refuel();
            truck.LoadTruck();
            truck.StartEngine();
            truck.TurnOnAirCond();

            //Assert
            Assert.AreEqual(truck.IsTankFull, true);
            Assert.AreEqual(truck.IsEngineRunning, true);
            Assert.AreEqual(truck.IsAirCondOn, true);
            Assert.AreEqual(truck.IsTruckLoaded, true);
        }
    }
}
