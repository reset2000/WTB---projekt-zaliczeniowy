using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //4. Jednoczesne dziedziczenie po interfejsie ITruckLoad i klasie FuelCar.
    public class Truck : FuelCar, ITruckLoad {
        private bool isTruckLoaded = false;
        public bool IsTruckLoaded {
            get { return isTruckLoaded; }
            set { isTruckLoaded = value; }
        }

        public void LoadTruck() {
            if (IsTruckLoaded) {
                Console.WriteLine("Ciężarówka już jest załadowana.");
            } else {
                Console.WriteLine("Ciężarówka została załadowana.");
                IsTruckLoaded = true;
            }
        }

        public void UnloadTruck() {
            if (!IsTruckLoaded) {
                Console.WriteLine("Ciężarówka nie jest załadowana.");
            } else {
                Console.WriteLine("Ciężarówka została rozładowana.");
                IsTruckLoaded = false;
            }
        }
    }
}