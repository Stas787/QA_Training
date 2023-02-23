using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Number_of_symbols_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter symbol sequence");
            string enterString = Console.ReadLine();
            List<int> results = new List<int>();
            StringBuilder subStrings = new StringBuilder();

            for (int i = 0; i < enterString.Length; i++)
            {
                subStrings.Append(enterString[i]);

                for (int j = 0; j < subStrings.Length - 1; j++)
                {
                    if (subStrings[subStrings.Length - 1] == subStrings[j])
                    {
                        subStrings.Remove(subStrings.Length - 1, 1);
                        results.Add(subStrings.Length);
                        subStrings.Clear();
                    }
                }
                if (i == enterString.Length - 1)
                {
                    results.Add(subStrings.Length);
                }
            }
            Console.WriteLine("Max number of uniq symbols in sequence");
            Console.WriteLine(results.Max());
        }
    }
}
