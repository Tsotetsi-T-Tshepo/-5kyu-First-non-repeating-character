using System;
using System.Collections.Generic;
using System.Linq;

namespace _5kyu__First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonRepeatingLetter("stress"));
        }
    }
    class Kata
    {
        //5 kyu https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/csharp
        public static string FirstNonRepeatingLetter(string s)
        {
            if (s.Length == 1)
            {
                return s.Substring(0, 1);
            }
            if (s.Distinct().Count() == 1)
            {
                return String.Empty;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s.ToLower().Count(n => n == char.ToLower(s[i])) == 1)
                {
                    return s[i].ToString();
                }
            }
            return String.Empty;
        }
        
    }
}
