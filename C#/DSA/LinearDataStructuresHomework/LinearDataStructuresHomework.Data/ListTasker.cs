using System;
using System.Collections.Generic;
using System.Linq;
using LinearDataStructuresHomework.Data.Contracts;

namespace LinearDataStructuresHomework.Data
{
    public class ListTasker : IListTasker, ITasker
    {
        private readonly IReadWriteProvider provider;
        private readonly IList<int> innerList;

        public ListTasker(IReadWriteProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException("provider");
            }

            this.provider = provider;
            this.innerList = new List<int>();
        }

        public int InnerCollectionCount
        {
            get { return this.innerList.Count; }
        }

        public void Fill(uint length)
        {
            var message = "Please enter a number: ";
            for (int i = 0; i < length; i++)
            {
                this.provider.WriteLine(message);
                var currentLine = this.provider.ReadLine();

                var isEmptyLine = currentLine == Environment.NewLine;
                if (isEmptyLine)
                {
                    return;
                }

                var number = 0;
                var isValid = int.TryParse(currentLine, out number);

                this.innerList.Add(number);
            }
        }

        public int CalculateSum()
        {
            if (this.InnerCollectionCount == 0)
            {
                throw new InvalidOperationException("InnerListCount");
            }

            var sum = 0;
            foreach (var number in this.innerList)
            {
                checked
                {
                    sum += number;
                }
            }

            return sum;
        }

        public double CalculateAverage(double sum)
        {
            var count = Convert.ToDouble(this.InnerCollectionCount);
            var average = sum / count;
            return average;
        }

        public IList<int> Sort()
        {
            return this.innerList.OrderBy(x => x).ToList();
        }

        public IList<int> GetTheLongestSubsequence()
        {
            var longestSubsequence = 0;
            var currentSubsequence = 0;
            var subsequenceNumber = default(int);

            for (var ind = 0; ind < this.innerList.Count; ind++)
            {
                var currentElement = this.innerList.ElementAt(ind);

                if (ind == 0)
                {
                    currentSubsequence = 1;
                }
                else
                {
                    var previousElement = this.innerList.ElementAt(ind - 1);

                    if (currentElement != previousElement)
                    {
                        currentSubsequence = 1;
                    }
                    else
                    {
                        ++currentSubsequence;
                    }
                }

                if (currentSubsequence > longestSubsequence)
                {
                    longestSubsequence = currentSubsequence;
                    subsequenceNumber = currentElement;
                }
            }

            return Enumerable.Repeat(subsequenceNumber, longestSubsequence).ToList();
        }

        public IEnumerable<int> GetOnlyPositiveNumbers()
        {
            var result = this.innerList.Where(x => x >= 0);
            return result;
        }
    }
}
