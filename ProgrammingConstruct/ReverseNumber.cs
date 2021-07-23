using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    
    class ReverseNumber
    {
        // variables
        int reverse = 0, remainder;
        int number = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static ReverseNumber()
        {
            Console.WriteLine("Enter the Number");
        }
        /// <summary>
        /// This is used to reverse the number.
        /// </summary>
        /// <returns></returns>
        public int Reverse()
        {
            while (number > 0) 
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            return reverse;
        }
    }
}
