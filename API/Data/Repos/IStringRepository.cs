namespace Challenges.Data.Repos
{
    public interface IStringRepository
    {
        void SaveStringInversionToDatabase(string words, string result);
        void SaveRemoveWhiteSpaceToDatabase(string words, string result);
    }
}