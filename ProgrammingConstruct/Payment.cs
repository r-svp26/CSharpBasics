using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class Payment
    {
        static int P, Y, R, payment, n, r;

        static Payment()
        {
            Console.WriteLine("Enter the Amount");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of Years");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the interest Rate");
            R = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// to evaluate the monthly payment.
        /// </summary>
        public static void monthlyPayment()
        {
            n = 12 * Y;
            r = R / (12 * 100);
            payment = P * r / 1 - (1 + r) ^ (-n);
            Console.WriteLine("Monthly Payment: " + payment);
        }
    }
}
