using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.Services
{
    public interface IMathematicalServices
    {
        int Addition(int one, int two);
        int Subtract(int num1, int num2);
        int Multiplication(int num1, int num2);
        double Division(int num1, int num2);
        int CalculateFactorial(int num1);
    }
}
