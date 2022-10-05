using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Jake:Driver
    {
        public Jake(RaceCar car) : base(car)
        {
            Name = "Jake";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}