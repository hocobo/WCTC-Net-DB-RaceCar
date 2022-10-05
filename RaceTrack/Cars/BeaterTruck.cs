using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class BeaterTruck:RaceCar
    {
        public BeaterTruck()
        {
            Name = "Jake's Beater Truck";
            TopSpeed = 100;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Name} starts up with no issues!");
        }

        public override void Brake()
        {
            Console.WriteLine($"{Name}'s ABS goes off every time he brakes!");
        }
    }
}