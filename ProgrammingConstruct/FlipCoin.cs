using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class FlipCoin
    {
        // constants 
        const int NUMBER_OF_TIMES_FLIP = 100;
        const double FLAG = 0.5;
        // variables
        double headCount = 0, tailCount = 0;
        double flip, headPercentage, tailPercentage;
        Random random = new Random();
        /// <summary>
        /// evaluate head and tail percentage.
        /// </summary>
        public void GetPercentage()
        {
            for (int i = 1; i <= NUMBER_OF_TIMES_FLIP; i++)
            {
                flip = random.NextDouble();
                if (flip < FLAG)
                    tailCount++;
                else
                    headCount++;
            }
            tailPercentage = (tailCount / NUMBER_OF_TIMES_FLIP) * 100;
            headPercentage = (headCount / NUMBER_OF_TIMES_FLIP) * 100;
            Console.WriteLine("Tail percentage:" + tailPercentage + "%");
            Console.WriteLine("Head percentage:" + headPercentage + "%");
        }
    }
}
