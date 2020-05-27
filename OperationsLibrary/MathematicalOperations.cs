using System;

namespace OperationsLibrary
{
    public static class MathematicalOperations
    {
        
        public static int Add(int int_1, int int_2)
        {
            
            int result = int_1 + int_2;

            return result;
        }

        public static int Subtract(int int_1, int int_2)
        {
            int result = int_1 - int_2;

            return result;

        }

        public static double Divide(int int_1, int int_2)
        {
            double result = (double) int_1 / int_2;

            return result;

        }

        public static int Multiply(int int_1, int int_2)
        {
            int result = int_1 * int_2;

            return result;

        }  
    }
}

