using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Transport
{
    internal class Scooter : Vehicle
    {
        public int MaxSpeed { get; set; }
        
        public Scooter (int maxSpeed, Chassis chassis, Engine engine, Transmission transmission) : base (chassis, engine, transmission)
        {
            MaxSpeed = maxSpeed;
            Console.WriteLine("Maximum speed of scooter " + MaxSpeed);
        }
    }
}
