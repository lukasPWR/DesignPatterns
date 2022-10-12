using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV2
{
    internal interface ICarBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void AddFuel();
        Car GetCar();
    }
}
