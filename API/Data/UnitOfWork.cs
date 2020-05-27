using Challenges.Data.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ChallengesContext _context;
        private IMathsRepository mathsRepo;
        private IStringRepository stringRepo;
        private ISortingRepository sortingRepo;

        public UnitOfWork(ChallengesContext context)
        {
            _context = context;
        }

        public IMathsRepository MathsRepo
        {
            get
            {
                if (mathsRepo == null)
                {
                    mathsRepo = new MathsRepository(_context);
                }
                return mathsRepo;
            }
        }

        public IStringRepository StringRepo
        {
            get
            {
                if (stringRepo == null)
                {
                    stringRepo = new StringRepository(_context);
                }
                return stringRepo;
            }
        }

        public ISortingRepository SortingRepo
        {
            get
            {
                if (sortingRepo == null)
                {
                    sortingRepo = new SortingRepository(_context);
                }
                return sortingRepo;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
