
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data.Entities
{
    public class SortingOutput
    {
        public int Id { get; set; }

        public ICollection<SortingValuesForOutput> OutputCharacterCollection { get; set; } = new List<SortingValuesForOutput>();
    }
}
