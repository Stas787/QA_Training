using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Bus : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        public Bus (int numberOfPassengers, Chassis chassis, Engine engine, Transmission transmission) : base (chassis, engine, transmission)
        {
            NumberOfPassengers = numberOfPassengers;
            Console.WriteLine("Number of passengers " + NumberOfPassengers);
        }
    }
}
