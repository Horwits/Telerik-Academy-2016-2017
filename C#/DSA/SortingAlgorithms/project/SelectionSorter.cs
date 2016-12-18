using System;
using System.Collections.Generic;

namespace SortingHomework
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var count = collection.Count;
            for (int i = 0; i < count - 2; i++)
            {
                var best = i;
                for (int j = i + 1; j < count - 1; j++)
                {
                    if (collection[best].CompareTo(collection[j]) > 0)
                    {
                        best = j;
                    }
                }

                if (best != i)
                {
                    Utils<T>.Swap(collection, i, best);
                }
            }
        }
    }
}