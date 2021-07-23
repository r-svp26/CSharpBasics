using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class LeapYear
    {
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
         static LeapYear() 
        {
            Console.WriteLine("Enter the Year");
        }
        int year = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// check year is leap year or not.
        /// </summary>
        public void IsLeapYear()
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                Console.WriteLine(year + "," + "Is a Leap Year.");
            else
                Console.WriteLine(year + "," + "Is not a Leap Year.");
        }
    }
}
