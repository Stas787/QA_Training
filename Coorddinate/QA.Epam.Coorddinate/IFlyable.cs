using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    public interface IFlyable
    {

        static int Speed { get; set;}
        /// <summary>
        /// provide dostance and coordinates for new point
        /// </summary>
        static Coordinates FlyTo()
        {
        //provide coordinates of the new point
        }
        /// <summary>
        /// Calculate flight time tio the new point
        /// </summary>
        void GetFlyTime()
        {
        //devides distance and speed
        }
    }
}
