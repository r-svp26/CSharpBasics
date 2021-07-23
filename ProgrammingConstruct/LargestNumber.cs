using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class LargestNumber
    {
        // varaibles
        int firstNumber, secondNumber, thirdNumber;
        public LargestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
        /// <summary>
        /// This method is used to return the max value among three numbers. 
        /// </summary>
        public void GetMax()
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine("Largest number is:" + firstNumber);
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
                Console.WriteLine("Largest number is:" + secondNumber);
            if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                Console.WriteLine("Largest number is:" + thirdNumber);
        }
    }
}
