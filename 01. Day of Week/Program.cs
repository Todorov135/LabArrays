using System;
using System.Linq;

namespace _01.Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber > 0 && dayNumber <=7)
            {
                   Console.WriteLine(dayOfWeek[dayNumber-1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
