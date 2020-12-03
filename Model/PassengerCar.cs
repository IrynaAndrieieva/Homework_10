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

        public int CompareTo(PassengerCar obj)
        {
            if (this.Consumption > obj.Consumption)
                return 1;
            if (this.Consumption < obj.Consumption)
                return -1;
            else
                return 0;
        }

    }
}
