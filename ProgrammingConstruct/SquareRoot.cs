using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class SquareRoot
    {
        static int c;
        double t, epsilon;

        static SquareRoot()
        {
            Console.WriteLine("Enter the number");
            c = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// method for finding square root using newton's law
        /// </summary>
        /// <returns>the square root of a number</returns>
        public double SQRT()
        {
            t = c;
            epsilon= 1e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;       
        }
    }
}
