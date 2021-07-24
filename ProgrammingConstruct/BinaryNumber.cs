using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class BinaryNumber
    {
        // variables 
        static int decimalValue, remainder;
        static string binary;
        static BinaryNumber()
        {
            Console.WriteLine("Enter the Decimal Value");
            decimalValue= Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// convert deicmal value to binary
        /// </summary>
        public static void ToBinary()
        {
            do
            {
                remainder = decimalValue % 2;
                binary = remainder + binary;
                decimalValue /= 2;
            } while (decimalValue != 0);
            Console.WriteLine("Binary Number:" +binary);
        }
    }
}
