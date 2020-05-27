using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsLibrary
{
    public static class StringInversion
    {
        public static string Invert(string word)
        {
            int stringLength = word.Length;

            char[] characters = new char[stringLength];

            string newWord = "";

            int i= 1;
            foreach (char letter in word)
            {
                characters[stringLength - i] = letter;
                i++;
            }
            
            
            foreach (char character in characters)
            {
                newWord += character;
            }
            return newWord;
        }
    }
}
