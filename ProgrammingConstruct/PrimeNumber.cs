using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class PrimeNumber
    {
        // variables
        int number = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static PrimeNumber()
        {
            Console.WriteLine("Enter the number");
        }
        /// <summary>
        /// This method is used to check number is prime or not.
        /// </summary>
        public bool Check_Prime() 
        {
            if (number == 0 || number == 1)
                return false;
            for (int i=2; i<=number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;      
        }
    }
}
