using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capitalizes the first letter of every sentence and the letter "I"
            Console.Write("Type your message:");
            String message = "";
            while (message == "")
            {
                message = Console.ReadLine();
            }
            message = message.Replace(" i ", " I ");
            char[] messageCharacters = message.ToCharArray();

            for (int letter = 0; letter < messageCharacters.Length; letter++)
            {
                if (letter > 2)
                {
                    if (char.IsPunctuation(messageCharacters[letter - 2]))
                    {
                        messageCharacters[letter] = char.ToUpper(messageCharacters[letter]);
                    }
                    //if (messageCharacters[letter] = "i" && char.IsPunctuation(messageCharacters[letter - 2]))
                    //{
                    //    messageCharacters[letter] = char.ToUpper(messageCharacters[letter]);
                        
                    //}
                }

                Console.Write(messageCharacters[letter]);
            }
            Console.ReadLine();
        }
    }
}
