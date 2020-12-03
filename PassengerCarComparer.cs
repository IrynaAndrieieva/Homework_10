using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class PassengerCarComparer : IComparer
    {
        public int passengerCarComparer(object first, object second)
        {
            var x = first as PassengerCar;
            var y = second as PassengerCar;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
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

