using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class PassengerCarComparer //пока он не работает, пытаюсь понять, как это сделать
    {
        public int passengerCarComparer(object first, object second)
        {
            var x = first as PassengerCar;
            var y = second as PassengerCar;

            if (x.Consumption > y.Consumption)
            {
                return 1;
            }
            else if (x.Consumption < y.Consumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

