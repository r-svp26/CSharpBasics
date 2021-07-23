﻿using System;

namespace ProgrammingConstruct
{
    class Program
    {
        // variables
        int option= Convert.ToInt32(Console.ReadLine());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static Program()
        {
            Console.WriteLine("Enter the option for Class.");
        }
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
                case 3:
                    {
                        PowTable powTable = new PowTable();
                        powTable.PrintTable();
                        break;
                    }
                case 4:
                    {
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.HarmonicPattern();
                        break;
                    }
                case 5:
                    {
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.PrimeFactorization();
                        break;
                    }
                case 6:
                    {
                        Quotient quotient = new Quotient();
                        quotient.GetQuotient();
                        break;
                    }
                default:
                    Console.WriteLine("Please! Enter the valid option.");
                    break;
                }
            }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InvokeClass();
        }
    }
}
