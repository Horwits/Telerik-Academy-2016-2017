using System;
using System.Collections.Generic;
using System.Linq;
using LinearDataStructuresHomework.Data.Contracts;

namespace LinearDataStructuresHomework.Data
{
    public class ArrayTasker : IArrayTasker
    {
        private readonly IReadWriteProvider provider;
        private readonly int[] innerArray;

        public ArrayTasker(IReadWriteProvider provider, uint length)
        {
            this.provider = provider;
            this.innerArray = new int[length];
        }

        public int InnerCollectionCount
        {
            get { return this.innerArray.Length; }
        }

        public void Fill()
        {
            var length = this.innerArray.Length;
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

                this.innerArray[i] = number;
            }
        }

        public IDictionary<int, int> GetTimesOccur()
        {
            var occurances = this.innerArray
                .GroupBy(x => x)
                .OrderBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.Count());

            return occurances;
        }

        public int? GetMajorant()
        {
            var numbersCount = this.innerArray.Count();

            return this.innerArray.Cast<int?>()
            .FirstOrDefault(x => this.innerArray.Count(y => y == x) >= (numbersCount / 2) + 1);
        }
    }
}