using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class HatchbackJaguar : PassengerCar
    {
        public HatchbackJaguar(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public override TypeOfPassengerCar TypeOfPassengerCar => TypeOfPassengerCar.Hatchback;

        public override string Name => "Jaguar Hatchback F-Pace SVR";

        public override double Price => 70000;
    }
}
