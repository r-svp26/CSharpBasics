using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class HarmonicNumber
    {
        int N = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static HarmonicNumber()
        {
            Console.WriteLine("Enter the value of N.");
        }
        /// <summary>
        /// print the harmonic pattern.
        /// </summary>
        public void HarmonicPattern()
        {
            for (int count = 1; count <= N; count++)
            {
                if (count == N)
                    Console.Write("1/" + count);
                else
                    Console.Write("1/" + count + " + ");
            }
        }
    }
}
