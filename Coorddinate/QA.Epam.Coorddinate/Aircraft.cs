using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal class Aircraft : IFlyable
    {
        Coordinates CurrentPosition { get; set; }

        public Aircraft(int x1, int y1, int z1)
        {
            CurrentPosition = new Coordinates(x1, y1, z1);
        }

        public static Coordinates FlyTo(int x2, int y2, int z2)
        {
            return new Coordinates(x2, y2, z2);
        }
        /// <summary>
        /// Calculates speed and time of aircraft
        /// </summary>
        /// <param name="speed"></param>
        /// <exception cref="ArgumentOutOfRangeException">Passenger aircraft speed limit</exception>

        public void GetFlyTime(int x2, int y2, int z2)
        {
            double speed = 200;
            double time = 0;            
            Coordinates newPoint = FlyTo(x2 ,y2 ,z2);
            double distance = Math.Sqrt((newPoint.X1 - CurrentPosition.X1) ^ 2 + (newPoint.Y1 - CurrentPosition.Y1) ^ 2 + (newPoint.Z1 - CurrentPosition.Z1) ^ 2);
            if (distance > 1000)
            {
                throw new ArgumentException("speed is overcomed");
            }
            while (distance > 0)
            {
                if (distance > 10)
                {

                    time += 10 / speed;
                }
                else
                {
                    time += distance / speed;
                }

                distance -= 10;
                speed += 10;
            }
        }

    }
}
