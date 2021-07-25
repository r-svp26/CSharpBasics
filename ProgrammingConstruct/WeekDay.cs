using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class WeekDay
    {
        static int month, day, year, m, d, y, x; 
        static WeekDay()
        {
            Console.WriteLine("Enter the Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// To Calculate Day Of a Week.
        /// </summary>
        /// <returns>DayOfWeek return day for week like Monday Tuesday...</returns>
        public int DayOfWeek()
        {
            y = year - (14 - month) / 12;
            x = y + (y / 4) - (y / 100) + (y / 400);
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * m / 12) % 7;
            return d;
        }
    }
}
