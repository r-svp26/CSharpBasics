using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class OddEven
    {
        // varaibles
        int number = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static OddEven()
        {
            Console.WriteLine("Enter the Number.");        
        }
        /// <summary>
        /// This method is used to check odd or even of a number. 
        /// </summary>
        public void CheckOddEven()
        {
            if (number % 2 == 0)
                Console.WriteLine(number + "," + "Is an even number.");
            else
                Console.WriteLine(number + "," + "Is an odd number.");
        }
    }
}
