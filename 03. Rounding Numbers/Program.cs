using System;
using System.Linq;

namespace _03.Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
               
                Console.WriteLine($"{arrayOfNumbers[i]} => {(int)Math.Round(arrayOfNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
