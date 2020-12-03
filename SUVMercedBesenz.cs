using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class SUVMercedBesenz : PassengerCar
    {
        public SUVMercedBesenz(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public override TypeOfPassengerCar TypeOfPassengerCar => TypeOfPassengerCar.Hatchback;

        public override string Name => "SUV Mercedes-Benz E-Class C238";

        public override double Price => 68000;
    }
}
