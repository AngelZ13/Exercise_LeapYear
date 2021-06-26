using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            LeapYear(1923);
            LeapYear(2028);

        }

        private static void LeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is a normal year.");
        }
    }
}
