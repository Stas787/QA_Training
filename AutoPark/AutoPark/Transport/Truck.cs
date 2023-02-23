using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(int loadCapacity, Chassis chassis, Engine engine, Transmission transmission) : base(chassis, engine, transmission)
        {
            LoadCapacity = loadCapacity;
            Console.WriteLine("Load capacity of truck " + loadCapacity);
        }        
    }
}
