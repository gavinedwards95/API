using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using OperationsLibrary;

namespace Challenges.Services
{
    public class MathematicalServices : IMathematicalServices
    {
        public int Addition(int num1, int num2)
        {
            var result = MathematicalOperations.Add(num1, num2);

            return result;
        }

        

        public double Division(int num1, int num2)
        {
            var result = MathematicalOperations.Divide(num1, num2);

            return result;
        }

        public int Multiplication(int num1, int num2)
        {
            var result = MathematicalOperations.Multiply(num1, num2);

            return result;
        }

        public int Subtract(int num1, int num2)
        {
            var result = MathematicalOperations.Subtract(num1, num2);

            return result;
        }

        public int CalculateFactorial(int num1)
        {
            var result = Factorial.CalcFactorial(num1);

            return result;
        }

    }
}
