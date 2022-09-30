using System;
using System.Linq;

namespace _02.Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputNumbers = int.Parse(Console.ReadLine());

            int[] numArr = new int [numberOfInputNumbers];

            for (int i = 0; i < numberOfInputNumbers; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                numArr[i] = currNum;    
            }
            for (int i = numArr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numArr[i]} ");
            }
        }
    }
}
