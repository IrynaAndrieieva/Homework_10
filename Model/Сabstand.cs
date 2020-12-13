using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract class Сabstand : IProducts
    {
        private readonly double consumption;
        private readonly string createdBy;

        protected Сabstand(double consumption, string createdBy)
        {
            this.consumption = consumption;
            this.createdBy = createdBy;
        }

        public abstract string Name { get; }

        public double Consumption => this.consumption;

        public string CreatedBy => this.createdBy;

        public abstract double Price { get; }

    }

}
