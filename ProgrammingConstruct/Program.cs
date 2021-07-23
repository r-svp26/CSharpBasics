using System;

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
            Console.WriteLine("Select the option from below");
            Console.WriteLine("1:FlipCoin 2:LeapYear 3:PowTable 4:HarmonicNumber 5:PrimeFactor");
            Console.WriteLine("6:Quotient 7:SwapNumber 8:OddEven 9:Albhabet 10:LargestNumber");
            Console.WriteLine("11:Fibonacci 12:PerfectNumber 13:PrimeNumber 14:ReverseNumber");
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
                case 7:
                    {
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.SwapTwoNumber();
                        break;
                    }
                case 8:
                    {
                        OddEven oddEven = new OddEven();
                        oddEven.CheckOddEven();
                        break;
                    }
                case 9:
                    {
                        Alphabet alphabet = new Alphabet();
                        alphabet.CheckVowelConsonant();
                        break;
                    }
                case 10:
                    {
                        LargestNumber largestNumber = new LargestNumber(21,36,25);
                        largestNumber.GetMax();
                        break;
                    }
                case 11:
                    {
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.printSeries();
                        break;
                    }
                case 12:
                    {
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Check_Perfect();
                        break;
                    }
                case 13:
                    {
                        PrimeNumber primeNumber = new PrimeNumber();
                        bool isPrime=primeNumber.Check_Prime();
                        Console.WriteLine(isPrime);
                        break;
                    }
                case 14:
                    {
                        ReverseNumber reverse = new ReverseNumber();
                        int reverseNumber = reverse.Reverse();
                        Console.WriteLine("Number after reversed:" +reverseNumber);
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
