using System;
using System.Collections.Generic;
using System.Text;

namespace QA.Epam.Coorddinate
{
    internal class Bird: IFlyable
    {
        public static Coordinates CurrentPopsition { get; set; }
        
        /// <summary>
        /// Speed calculates as random nubmber between 0 and 20
        /// </summary>
        public Bird(int x1, int y1, int z1)
        {
            CurrentPopsition = new Coordinates(x1, y1, z1);
        }
        /// <summary>
        /// Get coordinates of new point fot bird
        /// </summary>
        public static Coordinates FlyTo(int x2, int y2, int z2)
        {
            return new Coordinates(x2, y2, z2);           
        }
        /// <summary>
        /// Calculate flight time
        /// </summary>
        public static double GetFlyTime(int x2, int y2, int z2)
        {
            Random random = new Random();
            int speed = random.Next(20);
            Coordinates newPoint = FlyTo(x2, y2, z2);
            double distance = Math.Sqrt((newPoint.X1 -CurrentPopsition.X1) ^ 2 + (newPoint.Y1 - CurrentPopsition.Y1) ^ 2 + (newPoint.Z1 - CurrentPopsition.Z1) ^ 2);
            return distance / speed;
        }
    }
}
