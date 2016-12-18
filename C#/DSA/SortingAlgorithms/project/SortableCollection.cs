namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (var ind = 0; ind < this.Items.Count; ind++)
            {
                if (ind.CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            return this.BinarySearchRecursive(item, 0, this.Items.Count - 1);
        }

        public void Shuffle()
        {
            var random = new Random();
            var count = this.items.Count;
            for (int i = 0; i < count - 1; i++)
            {
                var randomNext = random.Next(i + 1, count);
                Utils<T>.Swap(this.items, i, randomNext);
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private bool BinarySearchRecursive(T key, int min, int max)
        {
            if (min > max)
            {
                return false;
            }
            else
            {
                var mid = (min + max) / 2;
                if (this.Items[mid].CompareTo(key) == 0)
                {
                    return true;
                }
                else if (this.Items[mid].CompareTo(key) > 0)
                {
                    return this.BinarySearchRecursive(key, min, mid - 1);
                }
                else
                {
                    return this.BinarySearchRecursive(key, mid + 1, max);
                }
            }
        }
    }
}