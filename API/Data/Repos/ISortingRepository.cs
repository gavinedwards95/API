using System.Collections.Generic;

namespace Challenges.Data.Repos
{
    public interface ISortingRepository
    {
        void SaveSortingToDatabase(List<char> characters, List<char> result);
    }
}