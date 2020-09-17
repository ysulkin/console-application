using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type message:");
            string message = null;
            while (message == null)
            {
                message = Console.ReadLine();
            }
            
            message = message.Trim();
            message = String.Concat(message + "  ");
            message = message.ToLower();

            char[] messageLetters = message.ToCharArray();
            
            int wordLength = 0;

            
            for (int i = 0; i < messageLetters.Length; i++)
            {
                if (i + 1 < messageLetters.Length)
                {
                    if (i >= 1)
                    {
                        if (char.IsWhiteSpace(messageLetters[i - 1]))
                        {
                            wordLength = 0;
                        }
                    }


                    if (char.IsWhiteSpace(messageLetters[i]) == false)
                    {
                       
                        if (char.IsWhiteSpace(messageLetters[i + 1]) == false)
                        {
                           Console.Write(messageLetters[i + 1]);

                        }
                       
                        wordLength++;
                    }
                    
                    else if (char.IsWhiteSpace(messageLetters[i]))
                    {                       
                        Console.Write(messageLetters[i - wordLength] + "ay ");
                        
                    }
        }
    }

            Console.ReadLine();
        }
    }
}
