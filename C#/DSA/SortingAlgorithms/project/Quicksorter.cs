namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            throw new NotImplementedException();
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
