using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OperationsLibrary;

namespace Challenges.Services
{
    public class StringServices : IStringServices
    {
        public string InvertString(string word)
        {
            string invertedString = StringInversion.Invert(word);

            return invertedString;
        }

        public string RemoveWhite(string message)
        {
            var modifiedString = RemoveWhiteSpace.NoWhiteSpace(message);

            return modifiedString;
        }
    }
}
