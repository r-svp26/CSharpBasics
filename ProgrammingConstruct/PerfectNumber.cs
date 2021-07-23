using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class PerfectNumber
    {
        // variables
        int sum = 0;
        int number = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static PerfectNumber()
        {
            Console.WriteLine("Enter the number:");
        }
        /// <summary>
        /// This method is used to check given number is perfect or not.
        /// </summary>
        public void Check_Perfect() 
        {
            for (int i=1; i<=number/2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number)
                Console.WriteLine(number +","+" Is a Perfect Number.");
            else
                Console.WriteLine(number + "," + " Is a not Perfect Number.");
        }
    }
}
