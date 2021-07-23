using System;

namespace ProgrammingConstruct
{
    class Program
    {
        // variables
        int option= Convert.ToInt32(Console.ReadLine());

        /// <summary>
        /// This method is used to call a specific class in the project.
        /// </summary>
        public void InvokeClass()
            {
                switch (option)
                {
                case 1:
                    {
                        FlipCoin flip = new FlipCoin();
                        flip.GetPercentage();
                        break;
                    }
                case 2:
                    {
                        LeapYear leapYear = new LeapYear();
                        leapYear.IsLeapYear();
                        break;
                    }
                default:
                    Console.WriteLine("Please! Enter the valid option.");
                    break;
                }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option for Class.");
            Program program = new Program();
            program.InvokeClass();
        }
    }
}
