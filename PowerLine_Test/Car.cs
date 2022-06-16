using System;
using System.Collections.Generic;
using System.Text;

namespace PowerLine_Test
{
    abstract class Car
    {
        protected CarType Type { get; set; } //тип ТС
        public float FuelConsumption { get; set; } //ср.расход топлива
        public sbyte FuelTankVolume { get; private set; } //объём бака
        public ushort Speed { get; set; } //скорость

        public Car(float FuelConsumption,sbyte FuelTankVolume) //конструктор 
        {
            this.FuelConsumption = FuelConsumption;
            this.FuelTankVolume = FuelTankVolume;
        }

        //расход топлива = количество литров топлива, которое вы заправили/сколько вы проехали x 100
        //сколько вы проехали = 100*количество литров топлива, которое вы заправили/расход топлива
        //расход с грузом: Qн = 0,01 х (Hsan * S + Hw * W), где  W = Gгр х Sгр (где Gгр – масса груза, т; Sгр – пробег с грузом, км);

        public float GetFuelVolumeConsumption() //расчёт сколько проедет на полном баке
        {
            return (ushort)(FuelTankVolume * 100 / FuelConsumption);
        }

        public float GetFuelVolumeConsumption(sbyte fuel) //расчёт сколько проедет на остаточном
        {
            return (ushort)(fuel * 100 / FuelConsumption);
        }

        public float GetFuelConsumptionWithCargo(float m) //расчёт запаса хода (расход) от груза(тонны)
        {
            float km = GetFuelVolumeConsumption(); //пробег на полном баке
            return 0.01f * (FuelConsumption * km + FuelConsumption * (m * km));
        }
    }

    public enum CarType
    {
        Passenger,
        Cargo,
        Sport
    }
}
