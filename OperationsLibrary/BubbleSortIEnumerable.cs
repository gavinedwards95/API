using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationsLibrary
{
    public static class BubbleSortIEnumerable
    {
        public static List<char> Sort(List<char> collection)
        {

            for (int j = 0; j < (collection.Count() - 1); j++)
            {
                for (int i = 0; i < (collection.Count() - 1); i++)
                {
                    char obj1 = collection[i];
                    char obj2 = collection[i + 1];

                    if (obj1 > obj2)
                    {
                        collection[i] = obj2;
                        collection[i + 1] = obj1;
                    }
                    else continue;
                }
            }
            return collection;
        }
    }
}
