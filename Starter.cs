﻿using System;
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
            var fullPrise = this.fullPriceServis.MakeCost();
            //Array.Sort(fullPrise.PassengerCar, new PassengerCarComparer()); //пока это не работает

            for (int i = 0; i < fullPrise.PassengerCar.Length; i++)
            {
                Console.WriteLine($"\nName: {fullPrise.PassengerCar[i].Name} \nСonsumption: {fullPrise.PassengerCar[i].Consumption} \nPrice: {fullPrise.PassengerCar[i].Price}");
            }
            Console.WriteLine("_____________________________");
            Console.WriteLine($"The cost of cars in the fleet: {fullPrise.Price}");
            Console.ReadKey();

            /*
            PassengerCarComparer p1 = new PassengerCarComparer { };

            PassengerCar[] automobile = new PassengerCar[] { p1 };
            Array.Sort(automobile);

            foreach (PassengerCar p in PassengerCarComparer)
            {
                Console.WriteLine($"{p.Name} - {p.Consumption}");
            }
            */
            Console.ReadLine();
        }
    }
}
