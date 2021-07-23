using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    class Alphabet
    {
        // varaibles
        char ch = Convert.ToChar(Console.ReadLine().ToLower());
        /// <summary>
        /// static constructor is used to display console message to user.
        /// </summary>
        static Alphabet()
        {
            Console.WriteLine("Enter the Character");
        }
        /// <summary>
        /// This method is used to check vowel and consonant. 
        /// </summary>
        public void CheckVowelConsonant()
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("Chracter " + ch + " is Vowel.");
            else
                Console.WriteLine("Chracter is Consonant.");
        }
    }
}
