using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    internal class Chassis
    {
        int NumberOfWheels { get; set; }
        int Number { get; set; }
        int PermissibleLoad { get; set; }

        public Chassis(int numberOfWheels, int number, int permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }

        public override string ToString()
        {
            return "Chassis: " + " number of wheels - "+ NumberOfWheels + " " +"number " 
                    + Number + " " +"Permissible load " + PermissibleLoad;
        }
    }
}
