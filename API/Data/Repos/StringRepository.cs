using Challenges.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data.Repos
{
    public class StringRepository : IStringRepository
    {
        private readonly ChallengesContext _context;

        public StringRepository(ChallengesContext context)
        {
            _context = context;
        }

        public void SaveStringInversionToDatabase(string words, string result)
        {
            StringInversion invert = new StringInversion();
            invert.String = words;
            invert.Result = result;
            _context.StringInversions.Add(invert);
            _context.SaveChanges();
        }

        public void SaveRemoveWhiteSpaceToDatabase(string words, string result)
        {
            WhiteSpaceRemoval noWhite = new WhiteSpaceRemoval();
            noWhite.String = words;
            noWhite.Result = result;
            _context.WhiteSpcaeRemovals.Add(noWhite);
            _context.SaveChanges();
        }


    }
}
