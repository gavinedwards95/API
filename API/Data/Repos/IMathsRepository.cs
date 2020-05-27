namespace Challenges.Data
{
    public interface IMathsRepository
    {
        void SaveAdditionToDatabase(int integerOne, int integerTwo, int result);
        void SaveSubtractionToDatabase(int integerOne, int integerTwo, int result);
        void SaveMultiplicationToDatabase(int integerOne, int integerTwo, int result);
        void SaveDivisionToDatabase(int integerOne, int integerTwo, double result);
        void SaveFactorialToDatabase(int integerOne, int result);
    }
}