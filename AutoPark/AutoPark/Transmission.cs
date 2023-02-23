using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    internal class Transmission
    {
        string Type { get; set; }

        string Manufacturer { get; set; }

        int NumberOfGears { get; set; }

        public Transmission(string type, string manufacturer, int numberOfGears)
        {
            Type = type;
            Manufacturer = manufacturer;
            NumberOfGears = numberOfGears;
        }

        public override string ToString()
        {
            return "Transmission: " + "Type - " + Type + " " +"made in " + Manufacturer + " " + "number of gears - " + NumberOfGears;
        }
    }
}
