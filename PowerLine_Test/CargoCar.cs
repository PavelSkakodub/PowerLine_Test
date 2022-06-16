using System;
using System.Collections.Generic;
using System.Text;

namespace PowerLine_Test
{
    class CargoCar:Car
    {
        private float cargo;
        public float LoadCapacity { get; set; } //грузоподьемность
        public float Cargo //вес груза 
        {
            get { return cargo; }
            set
            {
                if (value > LoadCapacity) throw new Exception("Cargo is very big");
                else
                {
                    cargo = value;
                    FuelConsumption *= (float)(100 + (value / 200) * 4) / 100; //уменьшаем р.топлива из-за веса руза на 4%
                }
            }
        }

        public CargoCar(float LoadCapacity, float cargo, float fuelc, sbyte fuelv) : base(fuelc, fuelv) //конструктор с грузом
        {
            this.LoadCapacity = LoadCapacity;
            Cargo = cargo;
            Type = CarType.Cargo;
        }

        public CargoCar(float fuelc, sbyte fuelv) : base(fuelc, fuelv) //конструктор без груза
        {
            Type = CarType.Cargo;
        }
    }
}
