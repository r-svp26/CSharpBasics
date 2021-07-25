using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class DistinctCoupon
    {
        // variables 
        static int N, random, count = 0, distinct = 0, value ;
        static DistinctCoupon()
            {
                Console.WriteLine("Enter N Distinct Coupon Number");
                N = Convert.ToInt32(Console.ReadLine());
            }
        public int GenerateCoupon()
        {
            random = new Random().Next(N);
            bool[] arr = new bool[N];
            while (distinct < N)
            {
                value = random;
                Console.WriteLine(value + " ");
                if (!arr[value])
                {
                    distinct++;
                    arr[value] = true;
                    Console.WriteLine(arr[value] + " ");
                }
                count++; 
            }
            return count;
        }
    }
}
