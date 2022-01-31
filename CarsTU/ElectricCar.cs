using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //Dziedziczenie po klasie CarStatus.
    public class ElectricCar : CarStatus {
        public override void Refuel() {
            if (IsTankFull) {
                Console.WriteLine("Akumulator jest już pełny.");
            } else {
                Console.WriteLine("Akumulator został naładowany.");
                IsTankFull = true;
            }
        }

        public override void StartEngine() {
            if (IsEngineRunning) {
                Console.WriteLine("Silnik elektryczny jest już włączony.");
            } else if (!IsTankFull) {
                Console.WriteLine("Akumulator jest pusty.");
            } else {
                Console.WriteLine("Silnik elektryczny został uruchomiony.");
                IsEngineRunning = true;
            }
        }

        public override void Drive() {
            if (!IsEngineRunning) {
                Console.WriteLine("Silnik elektryczny nie jest włączony.");
            } else if (!IsTankFull) {
                Console.WriteLine("Akumulator jest pusty.");
            } else {
                Console.WriteLine("Rozpoczęcie jazdy.");
                IsTankFull = false;
            }
        }

        public override void StopEngine() {
            if (!IsEngineRunning) {
                Console.WriteLine("Silnik elektryczny nie jest włączony.");
            } else {
                Console.WriteLine("Silnik elektryczny zosał zatrzymany.");
                IsEngineRunning = false;
            }
        }
        public override void TurnOnAirCond() {
            if (IsAirCondOn) {
                Console.WriteLine("Klimatyzacja jest już włączona.");
            } else {
                Console.WriteLine("Klimatyzacja została włączona.");
                IsAirCondOn = true;
            }
        }
        public override void TurnOffAirCond() {
            if (!IsAirCondOn) {
                Console.WriteLine("Klimatyzacja nie jest włączona.");
            } else {
                Console.WriteLine("Klimatyzacja została wyłączona.");
                IsAirCondOn = false;
            }
        }
    }
}