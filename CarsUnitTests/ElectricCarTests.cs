using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cars;

namespace CarsUnitTests {

    //Klasa implementująca testy jednostkowe dla klasy ElectricCar.
    [TestClass]
    public class ElectricCarTests {

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void ElectricCar_FFF() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.Drive();
            ec.StopEngine();

            //Assert
            Assert.AreEqual(ec.IsTankFull, false);
            Assert.AreEqual(ec.IsEngineRunning, false);
            Assert.AreEqual(ec.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void ElectricCar_FFT() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.TurnOnAirCond();

            //Assert
            Assert.AreEqual(ec.IsTankFull, false);
            Assert.AreEqual(ec.IsEngineRunning, false);
            Assert.AreEqual(ec.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void ElectricCar_FTF() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();
            ec.StartEngine();
            ec.Drive();

            //Assert
            Assert.AreEqual(ec.IsTankFull, false);
            Assert.AreEqual(ec.IsEngineRunning, true);
            Assert.AreEqual(ec.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void ElectricCar_FTT() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();

            //Assert
            Assert.AreEqual(ec.IsTankFull, false);
            Assert.AreEqual(ec.IsEngineRunning, true);
            Assert.AreEqual(ec.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void ElectricCar_TFF() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();

            //Assert
            Assert.AreEqual(ec.IsTankFull, true);
            Assert.AreEqual(ec.IsEngineRunning, false);
            Assert.AreEqual(ec.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void ElectricCar_TFT() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();
            ec.TurnOnAirCond();

            //Assert
            Assert.AreEqual(ec.IsTankFull, true);
            Assert.AreEqual(ec.IsEngineRunning, false);
            Assert.AreEqual(ec.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void ElectricCar_TTF() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();
            ec.StartEngine();

            //Assert
            Assert.AreEqual(ec.IsTankFull, true);
            Assert.AreEqual(ec.IsEngineRunning, true);
            Assert.AreEqual(ec.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu elektrycznego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy akumulator jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void ElectricCar_TTT() {
            //Arrange
            ElectricCar ec = new ElectricCar();

            //Act
            ec.Refuel();
            ec.StartEngine();
            ec.TurnOnAirCond();
            ec.Drive();
            ec.TurnOffAirCond();
            ec.StopEngine();
            ec.Refuel();
            ec.TurnOnAirCond();
            ec.StartEngine();

            //Assert
            Assert.AreEqual(ec.IsTankFull, true);
            Assert.AreEqual(ec.IsEngineRunning, true);
            Assert.AreEqual(ec.IsAirCondOn, true);
        }
    }
}
