using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal interface IFlyable
    {
        /// <summary>
        /// Coordinates of Current position
        /// </summary>
        public static Coordinates CurrentPosition { get; set; }

        /// <summary>
        /// provide coordinates of the new point
        /// </summary>
        Coordinates FlyTo(int x2, int y2, int z2);

        /// <summary>
        /// Calculate flight time tio the new point
        /// </summary>
        double GetFlyTime(double speed, int x2, int y2, int z2);
        
    }
}
