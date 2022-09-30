using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newList = new int[input.Length-1];

            for (int i = 0; i < input.Length-i; i++)
            {
                newList[i] = input[i] + input[i + 1];
                if (i == input.Length-1)
                {
                    input = newList;
                   
                }

            }
            Console.WriteLine(input[0]);
        }

    }
}
