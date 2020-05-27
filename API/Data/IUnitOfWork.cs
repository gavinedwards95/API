using Challenges.Data.Repos;

namespace Challenges.Data
{
    public interface IUnitOfWork
    {
        IMathsRepository MathsRepo { get; }
        IStringRepository StringRepo { get; }
        ISortingRepository SortingRepo { get; }

        void Save();
    }
}