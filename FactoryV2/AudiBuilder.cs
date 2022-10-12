using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV2
{
    internal class AudiBuilder: ICarBuilder
    {
        private Car car = new Car();
        public void BuildEngine()
        {
            car.EngineType = "Audi Engine";
        }

        public void BuildWheels()
        {
            car.Wheels = "Steel rims 15";
        }

        public void AddFuel()
        {
            car.Fuel = 100;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
