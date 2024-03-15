using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Sylvia : Driver
    {
        public Sylvia(RaceCar car) : base(car) 
        { 
            Name = "Sylvia";
            SkillLevel = 5;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
