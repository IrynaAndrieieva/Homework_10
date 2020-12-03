using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class IProducts
    {
        public interface Product
        {
            string Name { get; }

            double Price { get; }

            double Сonsumption { get; } // расход топлива

            string CreatedBy { get; } // изготовитель

        }
    }
}
