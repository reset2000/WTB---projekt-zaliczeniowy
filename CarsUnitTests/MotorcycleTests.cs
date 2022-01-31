using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cars;

namespace CarsUnitTests {

    //Klasa implementująca testy jednostkowe dla klasy Motorcycl.
    [TestClass]
    public class MotorcycleTests {

        //Test jednostkowy dla motocykla, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsMotorTankFull / Czy bak motocykla jest pełny -> fałsz
        //IsMotorEngineRunning / Czy silnik motocykla jest włączony -> fałsz
        [TestMethod]
        public void Motorcycle_FF() {
            //Arrange
            Motorcycle mc = new Motorcycle();

            //Act
            mc.Refuel();
            mc.StartEngine();
            mc.Drive();
            mc.StopEngine();

            //Assert
            Assert.AreEqual(mc.IsMotorTankFull, false);
            Assert.AreEqual(mc.IsMotorEngineRunning, false);
        }

        //Test jednostkowy dla motocykla, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsMotorTankFull / Czy bak motocykla jest pełny -> fałsz
        //IsMotorEngineRunning / Czy silnik motocykla jest włączony -> prawda
        [TestMethod]
        public void Motorcycle_FT() {
            //Arrange
            Motorcycle mc = new Motorcycle();

            //Act
            mc.Refuel();
            mc.StartEngine();
            mc.Drive();
            mc.StopEngine();
            mc.Refuel();
            mc.StartEngine();
            mc.Drive();

            //Assert
            Assert.AreEqual(mc.IsMotorTankFull, false);
            Assert.AreEqual(mc.IsMotorEngineRunning, true);
        }

        //Test jednostkowy dla motocykla, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsMotorTankFull / Czy bak motocykla jest pełny -> prawda
        //IsMotorEngineRunning / Czy silnik motocykla jest włączony -> fałsz
        [TestMethod]
        public void Motorcycle_TF() {
            //Arrange
            Motorcycle mc = new Motorcycle();

            //Act
            mc.Refuel();
            mc.StartEngine();
            mc.Drive();
            mc.Refuel();
            mc.StopEngine();

            //Assert
            Assert.AreEqual(mc.IsMotorTankFull, true);
            Assert.AreEqual(mc.IsMotorEngineRunning, false);
        }

        //Test jednostkowy dla motocykla, w którym
        //oczekiwane wyniki wyglądają następująco:
        //IsMotorTankFull / Czy bak motocykla jest pełny -> prawda
        //IsMotorEngineRunning / Czy silnik motocykla jest włączony -> prawda
        [TestMethod]
        public void Motorcycle_TT() {
            //Arrange
            Motorcycle mc = new Motorcycle();

            //Act
            mc.Refuel();
            mc.StartEngine();
            mc.Drive();
            mc.StopEngine();
            mc.Refuel();
            mc.StartEngine();

            //Assert
            Assert.AreEqual(mc.IsMotorTankFull, true);
            Assert.AreEqual(mc.IsMotorEngineRunning, true);
        }
    }
}
