using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    internal class Engine
    {
        int Power { get; set; }
        string Type { get; set; }
        double Volume { get; set; }
        int SerialNumber { get; set; }

        public Engine (int power, string type, double volume, int serialNumber )
        {
            Power = power;
            Type = type;
            Volume = volume;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return  "Engine: " + "Power - " + Power + " " + "Type - " + Type + " " + "Volume - " + Volume;
        }
    }
}
