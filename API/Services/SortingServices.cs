using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OperationsLibrary;

namespace Challenges.Services
{
    public class SortingServices : ISortingServices
    {
        public List<char> Sort(List<char> collection)
        {
            var result = BubbleSortIEnumerable.Sort(collection);

            return result;
        }
    }
}
