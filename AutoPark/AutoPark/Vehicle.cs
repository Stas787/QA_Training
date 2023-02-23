using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    internal class Vehicle
    {
        Chassis Chassis { get; set; }
        Engine Engine { get; set; }
        Transmission Transmission { get; set; }
        public Vehicle(Chassis chassis, Engine engine, Transmission transmission)
        {
            Chassis = chassis;
            Engine = engine;
            Transmission = transmission;
        }

        public override string ToString()
        {
            return Chassis.ToString() + "\n" + Engine.ToString() + "\n" + Transmission.ToString() ;
        }
    }
}
