using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class StationWagonAudi : PassengerCar
    {
        public StationWagonAudi(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public override TypeOfPassengerCar TypeOfPassengerCar => TypeOfPassengerCar.StationWagon;

        public override string Name => "Station Wagon Audi A6";

        public override double Price => 75000;
    }
}
