using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Car : Vehicle
    {
        public string Company;

        public Car (string company, Chassis chassis, Engine engine, Transmission transmission) : base (chassis, engine, transmission)
        {
            Company = company;
            Console.WriteLine("Car manufacturer " + Company);
        }
    }
}
