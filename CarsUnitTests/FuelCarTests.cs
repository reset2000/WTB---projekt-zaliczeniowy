using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cars;

namespace CarsUnitTests {

    //Klasa implementująca testy jednostkowe dla klasy FuelCar.
    [TestClass]
    public class FuelCarTests {

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void FuelCar_FFF() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();

            //Assert
            Assert.AreEqual(fc.IsTankFull, false);
            Assert.AreEqual(fc.IsEngineRunning, false);
            Assert.AreEqual(fc.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void FuelCar_FFT() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.TurnOnAirCond();

            //Assert
            Assert.AreEqual(fc.IsTankFull, false);
            Assert.AreEqual(fc.IsEngineRunning, false);
            Assert.AreEqual(fc.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void FuelCar_FTF() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();
            fc.StartEngine();
            fc.Drive();

            //Assert
            Assert.AreEqual(fc.IsTankFull, false);
            Assert.AreEqual(fc.IsEngineRunning, true);
            Assert.AreEqual(fc.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> fałsz
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void FuelCar_FTT() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();

            //Assert
            Assert.AreEqual(fc.IsTankFull, false);
            Assert.AreEqual(fc.IsEngineRunning, true);
            Assert.AreEqual(fc.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void FuelCar_TFF() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.Refuel();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();

            //Assert
            Assert.AreEqual(fc.IsTankFull, true);
            Assert.AreEqual(fc.IsEngineRunning, false);
            Assert.AreEqual(fc.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> fałsz
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void FuelCar_TFT() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();
            fc.TurnOnAirCond();

            //Assert
            Assert.AreEqual(fc.IsTankFull, true);
            Assert.AreEqual(fc.IsEngineRunning, false);
            Assert.AreEqual(fc.IsAirCondOn, true);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> fałsz
        [TestMethod]
        public void FuelCar_TTF() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();
            fc.StartEngine();

            //Assert
            Assert.AreEqual(fc.IsTankFull, true);
            Assert.AreEqual(fc.IsEngineRunning, true);
            Assert.AreEqual(fc.IsAirCondOn, false);
        }

        //Test jednostkowy dla samochodu spalinowego, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsTankFull / Czy bak jest pełny -> prawda
        //IsEngineRunning / Czy silnik jest włączony -> prawda
        //IsAirCondOn / Czy klimatyzacja jest włączona -> prawda
        [TestMethod]
        public void FuelCar_TTT() {
            //Arrange
            FuelCar fc = new FuelCar();

            //Act
            fc.Refuel();
            fc.StartEngine();
            fc.TurnOnAirCond();
            fc.Drive();
            fc.TurnOffAirCond();
            fc.StopEngine();
            fc.Refuel();
            fc.TurnOnAirCond();
            fc.StartEngine();

            //Assert
            Assert.AreEqual(fc.IsTankFull, true);
            Assert.AreEqual(fc.IsEngineRunning, true);
            Assert.AreEqual(fc.IsAirCondOn, true);
        }
    }
}
