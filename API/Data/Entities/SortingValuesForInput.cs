using Challenges.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data.Entities
{ 
    public class SortingValuesForInput
    {
       
        public SortingValuesForInput(int characterNumber, char character)
        {
            Character = character;
            CharacterNumber = characterNumber;
        }
        
        public int Id { get; set; }

        public int CharacterNumber { get; set; }

        public char Character { get; set; }

      //  public SortingInput SortingInput { get; set; }
    }
}
