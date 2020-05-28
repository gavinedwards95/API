using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data.Entities
{
    public class SortingValuesForOutput
    {

        public SortingValuesForOutput(char character)
        {
            Character = character;
        }

        public int ID { get; set; }

        public char Character { get; set; }

    }
}
