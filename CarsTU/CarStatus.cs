using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //3. Dziedziczenie po wielu (dwóch) interfejsach: ICar oraz IAirConditioning.
    public abstract class CarStatus : ICar, IAirConditioning {
        private bool isTankFull = false;
        private bool isEngineRunning = false;
        private bool isAirCondOn = false;

        public bool IsTankFull {
            get { return isTankFull; }
            set { isTankFull = value; }
        }

        public bool IsEngineRunning {
            get { return isEngineRunning; }
            set { isEngineRunning = value; }
        }

        public bool IsAirCondOn {
            get { return isAirCondOn; }
            set { isAirCondOn = value; }
        }

        public abstract void Refuel();
        public abstract void StartEngine();
        public abstract void Drive();
        public abstract void StopEngine();
        public abstract void TurnOnAirCond();
        public abstract void TurnOffAirCond();
    }
}
