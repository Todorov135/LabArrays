using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[inputArr.Length-1];

            while (inputArr.Length > 1)
            {


                for (int i = 0; i < inputArr.Length-1; i++)
                {
                    condensed[i] = inputArr[i] + inputArr[i + 1];

                    if (inputArr.Length - 2 == i)
                    {
                        inputArr = condensed;
                        condensed = new int[inputArr.Length - 1];
                    }

                }
            }
            Console.WriteLine(inputArr[0]);
          
        }
    }
}
