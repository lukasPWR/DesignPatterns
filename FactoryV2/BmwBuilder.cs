using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV2
{
    internal class BmwBuilder : ICarBuilder
    {
        private Car car = new Car();
        public void BuildEngine()
        {
            car.EngineType = "Bmw Engine";
        }

        public void BuildWheels()
        {
            car.Wheels = "Steel rims 18";
        }

        public void AddFuel()
        {
            car.Fuel = 50;
        }

        public Car GetCar()
        {
            return car;
        }
    }
        
}
