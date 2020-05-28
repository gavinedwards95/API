
using Challenges.Data;
using Challenges.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data.Repos
{
    public class SortingRepository : ISortingRepository
    {

        private readonly ChallengesContext _context;

        public SortingRepository(ChallengesContext context)
        {
            _context = context;
        }

        public void SaveSortingToDatabase(List<char> unordered, List<char> ordered)
        {
            SortingInput UnorderedCollection = new SortingInput();

            SortingOutput OrderedCollection = new SortingOutput();

            int i = 1;
            foreach(char character in unordered)
            {  
                UnorderedCollection.InputCharacterCollection.Add(new SortingValuesForInput(i,character));
                i++;
            }

            foreach (char letter in ordered)
            {
                OrderedCollection.OutputCharacterCollection.Add(new SortingValuesForOutput(letter));
            }

            _context.InputtedCharacters.Add(UnorderedCollection);
            _context.OutputtedCharacters.Add(OrderedCollection);
            //    _context.CharacterSortingOutputs.Add(sortOut);
            _context.SaveChanges();
        }
    }
}
