using System;
using System.Linq;

namespace _06.Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int currNum = inputArr[i];

                if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
                else
                {
                    oddSum += currNum;

                }
               

            }
            int total = evenSum - oddSum;
            Console.WriteLine(total);
        }
    }
}
