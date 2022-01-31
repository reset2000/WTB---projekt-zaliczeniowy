using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    //1. Utworzony interfejs ICar.
    public interface ICar {
        void Refuel();
        void StartEngine();
        void Drive();
        void StopEngine();
    }
}
