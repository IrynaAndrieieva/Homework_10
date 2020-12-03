using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class PassengerCarComparer /*: IComparable*/ // не работает
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
    
    /*
    public class PassengerCarComparer : IComparable
    {
        FullPriceServis fullPriceServis  = new FullPriceServis();
        public int passengerCarComparer(object o)
        {
            PassengerCarComparer p = o as fullPriceServis;
            if (p != null)
                return this.Consumption.CompareTo(p.Consumption);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

    }
    */
}

