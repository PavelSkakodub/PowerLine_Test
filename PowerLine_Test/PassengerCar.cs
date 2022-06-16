using System;
using System.Collections.Generic;
using System.Text;

namespace PowerLine_Test
{
    class PassengerCar:Car
    {
        private sbyte passengerCount;
        public sbyte PassengerCount //кол-во пассажиров с проверкой и изменением запаса хода
        {
            get { return passengerCount; }
            set
            {
                if (value > 4 || value <= 0) throw new Exception("Passenger max 4");
                else
                {
                    passengerCount = value;
                    FuelConsumption *= (float)(100 + value * 6) / 100; //уменьшаем на 6% в зав-ти от кол-ва пассажиров
                }
                    
            }
        }

        public PassengerCar(sbyte pcount, float fuelc, sbyte fuelv) : base(fuelc, fuelv) //конструктор с пассажирами
        {
            PassengerCount = pcount;
            Type = CarType.Passenger;
        }

        public PassengerCar(float fuelc, sbyte fuelv) : base(fuelc, fuelv) //конструктор без пассажиров
        {
            Type = CarType.Passenger;
        } 
    }
}
