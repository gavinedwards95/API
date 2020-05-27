using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace OperationsLibrary
{
    public static class Factorial
    {

        public static int CalcFactorial(int input)
        {
                int result;
                if (input == 1 || input == 0)
                {
                    result = 1;
                }
                else
                {
                    result = input * CalcFactorial(input - 1);
                }
                return result;
            
        }
    }
}
