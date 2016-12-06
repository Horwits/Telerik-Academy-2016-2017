namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
                    collection = this.Swap(collection, i, best);
                }
            }
        }

        private IList<T> Swap(IList<T> collection, int firstPosition, int secondPosition)
        {
            var minPosIsInvalid = firstPosition < 0 || firstPosition >= collection.Count;
            var maxPosIsInvalid = secondPosition < 0 || secondPosition >= collection.Count;

            if (minPosIsInvalid || maxPosIsInvalid)
            {
                throw new ArgumentOutOfRangeException();
            }

            var toBeSwappedValue = collection[firstPosition];
            collection[firstPosition] = collection[secondPosition];
            collection[secondPosition] = toBeSwappedValue;
            return collection;
        }
    }
}
