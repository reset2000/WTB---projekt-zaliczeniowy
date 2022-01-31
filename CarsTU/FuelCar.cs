using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //Dziedziczenie po klasie CarStatus.
    public class FuelCar : CarStatus {
        public override void Refuel() {
            if (IsTankFull) {
                Console.WriteLine("Bak jest już pełny.");
            } else {
                Console.WriteLine("Bak został napełniony.");
                IsTankFull = true;
            }
        }

        public override void StartEngine() {
            if (IsEngineRunning) {
                Console.WriteLine("Silnik spalinowy jest już włączony.");
            } else if (!IsTankFull) {
                Console.WriteLine("Bak jest pusty.");
            } else {
                Console.WriteLine("Silnik spalinowy został uruchomiony.");
                IsEngineRunning = true;
            }
        }

        public override void Drive() {
            if (!IsEngineRunning) {
                Console.WriteLine("Silnik spalinowy nie jest włączony.");
            } else if (!IsTankFull) {
                Console.WriteLine("Bak jest pusty.");
            } else {
                Console.WriteLine("Rozpoczęcie jazdy.");
                IsTankFull = false;
            }
        }

        public override void StopEngine() {
            if (!IsEngineRunning) {
                Console.WriteLine("Silnik spalinowy nie jest włączony.");
            } else {
                Console.WriteLine("Silnik spalinowy zosał zatrzymany.");
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
                Console.WriteLine("Klimatyzacja w nie jest włączona.");
            } else {
                Console.WriteLine("Klimatyzacja została wyłączona.");
                IsAirCondOn = false;
            }
        }
    }
}
