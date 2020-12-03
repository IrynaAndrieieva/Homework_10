using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract class PassengerCar : Сabstand
    {
        protected PassengerCar(double price, string createdBy)
            : base(price, createdBy)
        {
        }

        public abstract TypeOfPassengerCar TypeOfPassengerCar { get; }
    }
}
