using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
   
    //public class PassengerCarComparer : IComparable 
    //{
    //    PassengerCar passengerCar = new PassengerCar();
    //    public int CompareTo(object o)
    //    {
    //        PassengerCar p = o as PassengerCar;
    //        if (p != null)
    //            return this.fullPrice.CompareTo(this.fullPrice);
    //        else
    //            throw new Exception("Невозможно сравнить два объекта");
    //    }

    //}

    public class PassengerCarComparer : IComparer
    {
        
        public int Compare(object first, object second)
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

