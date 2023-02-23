using System;

namespace Numeric.Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueTrying = true;

            while (continueTrying)
            {
                try
                {
                    Console.WriteLine("Enter number then base of numeric system");
                    Console.WriteLine(ConvertToBase(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    continueTrying = false;
                }
                catch
                {
                    Console.WriteLine("Base must be numbers: 2, 8, 10 or 16");
                }
            }

        }

        private static string ConvertToBase(int number, int numericSystem)
        {
            while (numericSystem > 20 || numericSystem < 2)
            {
                Console.WriteLine("Base must be from 2 to 20");
                numericSystem = int.Parse(Console.ReadLine());
            }

            string result = Convert.ToString(number, numericSystem);

            return result;
        }
    }
}
