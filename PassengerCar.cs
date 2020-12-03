using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract class PassengerCar : Сabstand
    {
        protected PassengerCar(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public abstract TypeOfPassengerCar TypeOfPassengerCar { get; }
    }
}
