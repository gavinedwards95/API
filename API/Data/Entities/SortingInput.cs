using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Challenges.Data.Entities
{
    public class SortingInput
    {
        public int Id { get; set; }

        public List<char> CharacterCollection { get; set; }
        
    }
}
