using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
     public class VolkswagenMinivan : PassengerCar
    {
        public VolkswagenMinivan(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public override TypeOfPassengerCar TypeOfPassengerCar => TypeOfPassengerCar.Minivan;

        public override string Name => "Multivan Volkswagen T6.1";

        public override double Price => 57000;
    }
}
