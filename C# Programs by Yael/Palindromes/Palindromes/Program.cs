using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get word and divide into characters
            string word = null;
            while(word == null)
            {
                Console.Write("Type a word and press ENTER to see if it is a palindrome:");
                word = Console.ReadLine();
            }
                
            word = word.ToLower();
           
            char[] wordChars = word.ToCharArray();
            int l = wordChars.Length - 1;
            bool result = new bool();
            //Check if even or odd amount of letters
            //if (wordChars.Length % 2 == 0)
            
                //compare corresponding letters and stop when equal to each other
                for (int i = 0; i < wordChars.Length / 2; i++)
                {

                    if (wordChars[i] != wordChars[l - i])
                    {
                        result = false;
                        goto noPalindrome;
                    }
                    else
                    {
                        result = true;
                    }

                }

            noPalindrome:
            if (result == false)
            {
                Console.WriteLine("Sorry; " + word + " is not a Palindrome. Better luck next time.");
            }
            else
            {
                Console.WriteLine("You are correct; " + word + " is a Palindrome!");
            }
            Console.ReadLine();
        }
    }
}
