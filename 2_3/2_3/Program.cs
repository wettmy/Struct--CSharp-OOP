using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d1 = new SimpleDate(21, 4, 2024); // високосный
            var d2 = new SimpleDate(14, 9, 1975); // не високосный

            Console.WriteLine(d1);
            Console.WriteLine(d1.IsLeapYear()); // True
            Console.WriteLine(d2);
            Console.WriteLine(d2.IsLeapYear()); // False
            Console.ReadKey();
        }
    }

    public struct SimpleDate
    {
        public int Day;
        public int Month;
        public int Year;

        public SimpleDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public bool IsLeapYear()
        {
            int y = Year;
            return (y % 400 == 0) || (y % 4 == 0 && y % 100 != 0);

        }

        public override string ToString()
        {
            return $"{Day:D2}.{Month:D2}.{Year:D4}";
        }
    }
}
