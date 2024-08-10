using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Car : IVehicle, IDrivable
    {
        private int gasoline;

        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is Driving.");
            }
            else
            {
                Console.WriteLine("Not enough gasoline to drive.");
            }
        }

        public bool Refuel(int gasoline)
        {
            this.gasoline += gasoline;
            Console.WriteLine($"Refueled: {gasoline} liters. Total gasoline now: {this.gasoline} liters.");
            return true;
        }

        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }

        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }

        void IDrivable.Drive()
        {
            Console.WriteLine("The car is being driven by IDrivable.");
        }
    }

}
