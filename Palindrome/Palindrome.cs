using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (word.Length <= 2)
            {
                if (word.Length == 1)
                {
                    return true;
                }
                if (word.Substring(0, 1).ToLower() == word.Substring(1, 1).ToLower())
                {
                    return true;
                }
                return false;
            }

            if (word.Substring(0, 1).ToLower() == word.Substring(word.Length - 1, 1).ToLower())
            {
                // recursive call 
                return IsPalindrome(word.Substring(1, word.Length - 2));
            }

            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine(Palindrome.IsPalindrome("RACecAr"));
            Console.WriteLine(Palindrome.IsPalindrome("abuttuba"));
        }
    }
}