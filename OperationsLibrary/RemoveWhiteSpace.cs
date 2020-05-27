using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsLibrary
{
    public static class RemoveWhiteSpace
    {
        public static string NoWhiteSpace(string inputSentence)
        {
            string newSentence = "";
            foreach (char character in inputSentence)
            {
                if (char.IsWhiteSpace(character)) continue;
                newSentence += character;
            }

            return newSentence;
        }
    }
}
