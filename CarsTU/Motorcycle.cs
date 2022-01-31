using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //2. Dziedziczenie po interfejsie ICar.
    public class Motorcycle : ICar {
        private bool isMotorTankFull = false;
        private bool isMotorEngineRunning = false;

        public bool IsMotorTankFull {
            get { return isMotorTankFull; }
            set { isMotorTankFull = value; }
        }
        
        public bool IsMotorEngineRunning {
            get { return isMotorEngineRunning; }
            set { isMotorEngineRunning = value; }
        }

        public void Refuel() {
            if (IsMotorTankFull) {
                Console.WriteLine("Bak motocykla jest już pełny.");
            } else {
                Console.WriteLine("Bak motocykla został napełniony.");
                IsMotorTankFull = true;
            }
        }

        public void StartEngine() {
            if (IsMotorEngineRunning) {
                Console.WriteLine("Silnik motocykla jest już włączony.");
            } else if (!IsMotorTankFull) {
                Console.WriteLine("Bak motocykla jest pusty.");
            } else {
                Console.WriteLine("Silnik motocykla został uruchomiony.");
                IsMotorEngineRunning = true;
            }
        }

        public void Drive() {
            if (!IsMotorEngineRunning) {
                Console.WriteLine("Silnik motocykla nie jest włączony.");
            } else if (!IsMotorTankFull) {
                Console.WriteLine("Bak motocykla jest pusty.");
            } else {
                Console.WriteLine("Rozpoczęcie jazdy.");
                IsMotorTankFull = false;
            }
        }

        public void StopEngine() {
            if (!IsMotorEngineRunning) {
                Console.WriteLine("Silnik motocykla nie jest włączony.");
            } else {
                Console.WriteLine("Silnik motocykla zosał zatrzymany.");
                IsMotorEngineRunning = false;
            }
        }
    }
}
