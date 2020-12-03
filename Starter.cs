using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    class Starter
    {
        private readonly IFullPriceServis fullPriceServis;

        public Starter()
        {
            this.fullPriceServis = new FullPriceServis();
        }

        public void Run()
        {
            
            var fullPrice = this.fullPriceServis.MakeCost();
            Array.Sort(fullPrice.PassengerCar, new PassengerCarComparer());

            for (int i = 0; i < fullPrice.PassengerCar.Length; i++)
            {
                Console.WriteLine($"\nName: {fullPrice.PassengerCar[i].Name} \nPrice: {fullPrice.PassengerCar[i].Price} \nConsumption: {fullPrice.PassengerCar[i].Consumption}");
            }

            Console.WriteLine($"The cost of cars in the fleet: {fullPrice.Price}");


            Console.ReadLine();
        }
    }
}
