using System;
using AutoPark.Transport;


namespace AutoPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chassis busChassis = new Chassis(6, 345, 50);
            Engine busEngine = new Engine(350, "diesel", 4.0, 3124555);
            Transmission busTransmission = new Transmission("mechanical", "German", 5);
            Bus bus = new Bus(300, busChassis, busEngine, busTransmission);
            Console.WriteLine(bus);
            Console.ReadLine();
        }
    }
}
