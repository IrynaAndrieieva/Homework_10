using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract class Car : Сabstand
    {
        protected Car(double consumption, string createdBy)
            : base(consumption, createdBy)
        {
        }

        public abstract bool IsElectricCar { get; }
    }
}
