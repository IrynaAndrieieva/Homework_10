using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class FullPriceServis : IFullPriceServis
    {
        public FullPriceServis()
        {
        }

        public FullPrice MakeCost()
        {
            var passengerCar = new PassengerCar[]
            {
                new VolkswagenMinivan(12.5,"Volkswagen"),
                new SUVMercedBesenz(7.0, "Merced Besenz"),
                new StationWagonAudi(11.5, "Audi"),
                new HatchbackJaguar (6.5, "Jaguar"),
            };

            var price = 0d;
            for (var i = 0; i < passengerCar.Length; i++)
            {
                price += passengerCar[i].Price;
            }

            return new FullPrice { PassengerCar = passengerCar, Price = price };
        }

    }
}
