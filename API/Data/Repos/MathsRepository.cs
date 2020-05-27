using Challenges.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Data
{
    public class MathsRepository : IMathsRepository
    {
        private readonly ChallengesContext _context;

        public MathsRepository(ChallengesContext context)
        {
           _context = context;
        }

        public void SaveAdditionToDatabase(int integerOne, int integerTwo, int result)
        {
            Addition add = new Addition();
            add.IntegerOne = integerOne;
            add.IntegerTwo = integerTwo;
            add.Result = result;
            _context.Additions.Add(add);
            _context.SaveChanges();
        }

        public void SaveSubtractionToDatabase(int integerOne, int integerTwo, int result)
        {
            Subtraction minus = new Subtraction();
            minus.IntegerOne = integerOne;
            minus.IntegerTwo = integerTwo;
            minus.Result = result;
            _context.Subtractions.Add(minus);
            _context.SaveChanges();
        }

        public void SaveMultiplicationToDatabase(int integerOne, int integerTwo, int result)
        {
            Multiplication multiply = new Multiplication();
            multiply.IntegerOne = integerOne;
            multiply.IntegerTwo = integerTwo;
            multiply.Result = result;
            _context.Multiplications.Add(multiply);
            _context.SaveChanges();
        }

        public void SaveDivisionToDatabase(int integerOne, int integerTwo, double result)
        {
            Division divide = new Division();
            divide.IntegerOne = integerOne;
            divide.IntegerTwo = integerTwo;
            divide.Result = result;
            _context.Divisions.Add(divide);
            _context.SaveChanges();
        }

        public void SaveFactorialToDatabase(int integerOne, int result)
        {
            Factorial factorial = new Factorial();
            factorial.Integer = integerOne;
            factorial.Result = result;
            _context.Factorials.Add(factorial);
            _context.SaveChanges();
        }


    }
}
