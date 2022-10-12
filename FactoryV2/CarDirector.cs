using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV2
{
    internal class CarDirector
    {
        public void ConstructCar(ICarBuilder builder)
        {
            builder.BuildEngine();
            builder.BuildEngine();
            builder.AddFuel();

        }
    }
}
