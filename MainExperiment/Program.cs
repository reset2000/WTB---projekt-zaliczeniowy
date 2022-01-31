using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Cars;

namespace MainExperiment {
    class Program {
        static void Main( string[] args ) {
            //Obiekty klas ElectricCar i FuelCar, które dziedziczą po klasie abstrakcyjnej CarStatus
            //(klasa CarStatus dziedziczy po dwóch interfejsach: ICar oraz IAirConditioning).
            ElectricCar eCar = new ElectricCar();
            FuelCar fCar = new FuelCar();

            //Utworzenie obiektu klasy Truck, która dziedziczy po po interfejsie ITruckLoad i klasie FuelCar.
            Truck truck = new Truck();
            //Utworzenie obiektu klasy Motorcycle, która dziedziczy po po interfejsie ICar.
            Motorcycle motorcycle = new Motorcycle();

            //Testy do laboratorium nr 1:
            Console.WriteLine("Samochód elektryczny:\n");

            eCar.StopEngine();
            eCar.Refuel();
            eCar.StopEngine();
            eCar.Drive();
            eCar.StartEngine();
            eCar.Drive();
            eCar.Drive();

            Console.WriteLine("");

            eCar.TurnOffAirCond();
            eCar.TurnOnAirCond();
            eCar.TurnOnAirCond();
            eCar.TurnOffAirCond();

            Console.WriteLine("\nSamochód spalinowy:\n");

            fCar.StopEngine();
            fCar.Refuel();
            fCar.StopEngine();
            fCar.Drive();
            fCar.StartEngine();
            fCar.Drive();
            fCar.Drive();

            Console.WriteLine("");

            fCar.TurnOffAirCond();
            fCar.TurnOnAirCond();
            fCar.TurnOnAirCond();
            fCar.TurnOffAirCond();

            //Testy do laboratorium nr 2:
            Console.WriteLine("\nSamochód ciężarowy:\n");

            truck.StopEngine();
            truck.Refuel();
            truck.StopEngine();
            truck.Drive();
            truck.StartEngine();
            truck.Drive();
            truck.Drive();

            Console.WriteLine("");

            truck.TurnOffAirCond();
            truck.TurnOnAirCond();
            truck.TurnOnAirCond();
            truck.TurnOffAirCond();

            Console.WriteLine("\nMotocykl:\n");

            motorcycle.StopEngine();
            motorcycle.Refuel();
            motorcycle.StopEngine();
            motorcycle.Drive();
            motorcycle.StartEngine();
            motorcycle.Drive();
            motorcycle.Drive();

            Console.ReadLine();
        }
    }
}
