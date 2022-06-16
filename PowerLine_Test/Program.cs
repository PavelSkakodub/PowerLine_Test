using System;

namespace PowerLine_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passengerCar = new PassengerCar(5.6f, 40);
            CargoCar cargoCar = new CargoCar(7.8f, 60);
            SportCar sportCar = new SportCar(6.2f, 55);

            Console.WriteLine($"[Passenger] Расход топлива: {passengerCar.FuelConsumption}, Бак: {passengerCar.FuelTankVolume}, хватит на {passengerCar.GetFuelVolumeConsumption()} км.");
            Console.WriteLine($"[Cargo] Расход топлива: {cargoCar.FuelConsumption}, Бак: {cargoCar.FuelTankVolume}, хватит на {cargoCar.GetFuelVolumeConsumption()} км.");

            passengerCar.PassengerCount = 3;
            passengerCar.Speed = 140;

            cargoCar.LoadCapacity = 1200;
            cargoCar.Cargo = 680;

            Console.WriteLine("Значения после изменения параметров автомобилей");
            Console.WriteLine($"[Passenger] Расход топлива: {passengerCar.FuelConsumption}, Бак: {passengerCar.FuelTankVolume}, хватит на {passengerCar.GetFuelVolumeConsumption()} км.");
            Console.WriteLine($"[Cargo] Расход топлива: {cargoCar.FuelConsumption}, Бак: {cargoCar.FuelTankVolume}, хватит на {cargoCar.GetFuelVolumeConsumption()} км.");

            Console.ReadKey();
        }
    }
}
