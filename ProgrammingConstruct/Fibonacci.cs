using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    
    class Fibonacci
    {
        // variables
        int first = 0, second = 1, ficonacci;
        int limit = Convert.ToInt32(Console.ReadLine());
        static Fibonacci()
        {
            Console.WriteLine("Enter the series limit");
        }
        /// <summary>
        /// This method is used to print the ficonacci series.
        /// </summary>
        public void printSeries() 
        {
            for(int i=1; i<=limit; i++ )
            {
                ficonacci = first + second;
                Console.Write(" " + ficonacci);
                first = second;
                second = ficonacci;
            }
        }
    }
}
