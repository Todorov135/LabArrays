using System;
using System.Linq;

namespace _05.Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfEven = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] %2==0)
                {
                    sumOfEven += arrayOfNumbers[i];
                }

            }
            Console.WriteLine(sumOfEven);   

        }
    }
}
