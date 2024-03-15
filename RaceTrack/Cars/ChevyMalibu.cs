using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ChevyMalibu : RaceCar
    {
        public ChevyMalibu()
        {
            Name = "Chevy Malibu";
            TopSpeed = 80;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} purrs to life.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is stopping quickly!");
            base.Brake();
        }
    }
}
