using Challenges.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Challenges.Data
{
    public class ChallengesContext : DbContext
    {
       
       public ChallengesContext(DbContextOptions <ChallengesContext> options) : base(options)
      {
            
      }
        public DbSet<Addition> Additions { get; set; }
        public DbSet<Subtraction> Subtractions { get; set; }
        public DbSet<Multiplication> Multiplications { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Factorial> Factorials { get; set; }
        public DbSet<StringInversion> StringInversions { get; set; }
        public DbSet<WhiteSpaceRemoval> WhiteSpcaeRemovals { get; set; }
        public DbSet<SortingInput> InputtedCharacters { get; set; }
        public DbSet<SortingOutput> OutputtedCharacters { get; set; }
        
    }
}
