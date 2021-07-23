using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class PrimeFactor
    {
        int number = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static PrimeFactor()
        {
            Console.WriteLine("Enter the Number.");
        }
        /// <summary>
        /// print the prime factor of a number
        /// </summary>
        public void PrimeFactorization()
        {
            for (int i = 2; i < number; i++)
            {
                int primeCount = 2;
                for (int j = 2; j < number; j++)
                {
                    if (i % j == 0)
                        primeCount = 3;
                    break;
                }
                if (primeCount == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
