using System;
using System.Collections.Generic;
using System.Text;

namespace PowerLine_Test
{
    class SportCar:Car
    {
        public SportCar(float fuelc, sbyte fuelv) : base(fuelc, fuelv)
        {
            Type = CarType.Sport;
        }
    }
}
