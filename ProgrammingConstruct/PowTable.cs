using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class PowTable
    {
        int pow = 1;
        int N = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static PowTable()
        {
            Console.WriteLine("Enter the value of N.");
        }
        /// <summary>
        /// print table of a N
        /// </summary>
        public void PrintTable()
        {
            for (int i = 1; i <= N; i++)
            {
                pow *= 2;
                Console.WriteLine(N + "*" + i + "=" + pow);
            }
        }
    }
}
