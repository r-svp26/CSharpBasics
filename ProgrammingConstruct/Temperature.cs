using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class Temperature
    {
        // variables
        static double celcius, fahrenheit, celciusValue, fahrenhietValue;
        /// <summary>
        /// display the console message to user for input.
        /// </summary>
        static Temperature()
        {
            Console.WriteLine("Enter the value of Degree");
            celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Fahrenheit");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// This method is used to evaluate the temperature conversion.
        /// </summary>
        public static void temperatureConversion()
        {
            fahrenhietValue = (celcius * 9 / 5) + 32;
            Console.WriteLine("Celsius to Fahrenheit:" + fahrenhietValue +" F");
            celciusValue = (fahrenheit -32 ) * 5/9;
            Console.WriteLine("Fahrenheit to Celcius:" + celciusValue+ " D");
        }
    }
}
