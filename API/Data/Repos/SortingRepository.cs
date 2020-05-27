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

        public void SaveSortingToDatabase(List<char> characters, List<char> result)
        {
            SortingInput sortIn = new SortingInput();
            SortingOutput sortOut = new SortingOutput();
            sortIn.CharacterCollection = characters;
            sortOut.Result = result;
           // _context.CharacterSortingInputs.Add(sortIn);
           // _context.CharacterSortingOutputs.Add(sortOut);
            _context.SaveChanges();
        }



    }
}
