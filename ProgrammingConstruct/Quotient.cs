using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class Quotient
    {
        // varaibles
        int quotient, remainder;
        int dividend = Convert.ToInt32(Console.ReadLine());
        int divisor = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static Quotient()
        {
            Console.WriteLine("Enter the Value of Divident and Divisor.");
        }
        /// <summary>
        /// This method is used to evaluate quotient and remainder.
        /// </summary>
        public void GetQuotient()
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
