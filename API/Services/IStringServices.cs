using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Services
{
    public interface IStringServices
    {
        string InvertString(string word);
        string RemoveWhite(string message);
    }
}
