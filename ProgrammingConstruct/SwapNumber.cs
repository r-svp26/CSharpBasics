using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class SwapNumber
    {
        // varaibles
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static SwapNumber()
        {
            Console.WriteLine("Enter the First Number and Second Number");
        }
        /// <summary>
        /// This method is used to swap the value of two numbers using operators.
        /// </summary>
        public void SwapTwoNumber()
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("First number after swap:" + firstNumber);
            Console.WriteLine("Second number after swap:" + secondNumber);
        }
    }
}
